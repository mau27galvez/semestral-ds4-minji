using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.comment;

[ApiController]
[Route("[controller]")]
public class CommentController(CommentService commentService) : ControllerBase
{
    [HttpPost]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] CreateCommentRequest commentRequest)
    {
        var userId = Guid.Parse(User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);
        var id = Guid.NewGuid();
        var createdAt = DateTime.UtcNow.ToUniversalTime();

        if (!Guid.TryParse(commentRequest.GroupId, out var groupId))
        {
            return BadRequest("Invalid group id");
        }

        await commentService.CreateComment(new CommentRequest(id, groupId, userId, commentRequest.Content, createdAt));
        return Ok();
    }

    [HttpPatch("{commentId:guid}")]
    public async Task<IActionResult> Update(Guid commentId, [FromBody] UpdateCommentApiRequest commentRequest)
    {
        var userId = Guid.Parse(User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);

        if (commentRequest.Content.Length > 255)
        {
            return BadRequest("Content is too long");
        }

        await commentService.UpdateComment(new UpdateCommentRequest(commentId, userId, commentRequest.Content));
        return Ok();
    }

    [HttpDelete("{commentId:guid}")]
    public async Task<IActionResult> Delete(Guid commentId)
    {
        var userId = Guid.Parse(User.Claims.First(c => c.Type == ClaimTypes.NameIdentifier).Value);

        await commentService.DeleteComment(new DeleteCommentRequest(commentId, userId));
        return Ok();
    }
}

public record CreateCommentRequest(
    [Required]
    string GroupId,
    [Required]
    [StringLength(255)]
    string Content
);

public record UpdateCommentApiRequest(
    [Required]
    [StringLength(255)]
    string Content
);
