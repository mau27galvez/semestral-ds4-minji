using Microsoft.AspNetCore.Mvc;
using WebApplication1.comment;
using WebApplication1.idol;

namespace WebApplication1.group;

[ApiController]
[Route("[controller]")]
public class GroupController(GroupService groupService) : ControllerBase
{
    [HttpGet(Name = "GetGroups")]
    public async Task<IEnumerable<GroupResponse>> Get()
    {
        return await groupService.GetGroups();
    }

    [HttpGet("{groupId:guid}", Name = "GetGroupById")]
    public async Task<GroupResponse> GetById(Guid groupId)
    {
        return await groupService.GetGroupById(groupId);
    }

    [HttpGet("{groupId:guid}/idol", Name = "GetIdolsByGroupId")]
    public async Task<IEnumerable<IdolResponse>> GetIdolsByGroupId(Guid groupId)
    {
        return await groupService.GetIdolsByGroupId(groupId);
    }

    [HttpGet("{groupId:guid}/comment", Name = "GetCommentsByGroupId")]
    public async Task<IEnumerable<CommentResponse>> GetByGroupId(Guid groupId)
    {
        return await groupService.GetCommentsByGroupId(groupId);
    }
}
