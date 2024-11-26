using Microsoft.EntityFrameworkCore;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.comment;

public class CommentService(AppDbContext appDbContext)
{
    public async Task CreateComment(CommentRequest commentRequest)
    {
        var comment = new Comment(
            commentRequest.Id,
            commentRequest.GroupId,
            commentRequest.AuthorId,
            commentRequest.Content,
            commentRequest.CreatedAt,
            null
        );

        await appDbContext.Comments.AddAsync(comment);
        await appDbContext.SaveChangesAsync();
    }

    public async Task UpdateComment(UpdateCommentRequest commentRequest)
    {
        var comment = await appDbContext.Comments.FindAsync(commentRequest.Id);

        if (comment == null)
        {
            throw new Exception("Comment not found");
        }

        if (comment.AuthorId != commentRequest.AuthorId)
        {
            throw new Exception("You are not the author of this comment");
        }

        // Create a new instance with updated properties
        var updatedComment = comment with { Content = commentRequest.Content, UpdatedAt = DateTime.UtcNow };

        // Detach the existing entity
        appDbContext.Entry(comment).State = EntityState.Detached;

        // Attach the new instance and mark it as modified
        appDbContext.Comments.Update(updatedComment);
        await appDbContext.SaveChangesAsync();
    }

    public async Task DeleteComment(DeleteCommentRequest commentRequest)
    {
        var comment = await appDbContext.Comments.FindAsync(commentRequest.Id);

        if (comment == null)
        {
            throw new Exception("Comment not found");
        }

        if (comment.AuthorId != commentRequest.AuthorId)
        {
            throw new Exception("You are not the author of this comment");
        }

        appDbContext.Comments.Remove(comment);
        await appDbContext.SaveChangesAsync();
    }
}

public record CommentResponse(
    string Id,
    string GroupId,
    string AuthorId,
    string AuthorUsername,
    string Content,
    string CreatedAt,
    string? UpdatedAt
);

public record CommentRequest(
    Guid Id,
    Guid GroupId,
    Guid AuthorId,
    string Content,
    DateTime CreatedAt
);

public record UpdateCommentRequest(
    Guid Id,
    Guid AuthorId,
    string Content
);

public record DeleteCommentRequest(
    Guid Id,
    Guid AuthorId
);
