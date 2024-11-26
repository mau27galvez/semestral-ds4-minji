using System.Globalization;
using Microsoft.EntityFrameworkCore;
using WebApplication1.comment;
using WebApplication1.idol;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.group;

public class GroupService(AppDbContext appDbContext)
{
    public async Task<IEnumerable<GroupResponse>> GetGroups()
    {
        var groups = await appDbContext.Groups.ToListAsync();
        var groupsResponse = groups.Select(group => new GroupResponse(
            group.Id.ToString(),
            group.Name,
            group.Description,
            group.Photo
        )).ToList();

        return groupsResponse;
    }

    public async Task<GroupResponse> GetGroupById(Guid groupId)
    {
        var group = await appDbContext.Groups.Where(group => group.Id == groupId).FirstAsync();
        var groupResponse = new GroupResponse(
            group.Id.ToString(),
            group.Name,
            group.Description,
            group.Photo
        );

        return groupResponse;
    }

    public async Task<IEnumerable<IdolResponse>> GetIdolsByGroupId(Guid groupId)
    {
        var idols = await appDbContext.Idols.Where(idol => idol.GroupId == groupId).ToListAsync();
        var idolsResponse = idols.Select(idol => new IdolResponse(
            idol.Id.ToString(),
            idol.GroupId.ToString(),
            idol.Name,
            idol.RealName,
            idol.About,
            idol.Photo
        )).ToList();

        return idolsResponse;
    }

    public async Task<IEnumerable<CommentResponse>> GetCommentsByGroupId(Guid groupId)
    {
        var comments = await appDbContext
            .Comments
            .Where(comment => comment.GroupId == groupId)
            .ToListAsync();

        var commentsResponse = comments
            .Select(comment => new CommentResponse(
                comment.Id.ToString(),
                comment.GroupId.ToString(),
                comment.AuthorId.ToString(),
                GetAuthorUsername(comment.AuthorId),
                comment.Content,
                comment.CreatedAt.ToString(CultureInfo.InvariantCulture),
                comment.UpdatedAt?.ToString(CultureInfo.InvariantCulture)
            )).ToList();

        return commentsResponse;
    }

    private string GetAuthorUsername(Guid authorId)
    {
        var user = appDbContext.Users.FirstOrDefault(u => u.Id == authorId);
        return user?.Email?.Split("@")[0] ?? "Unknown";
    }
}

public record GroupResponse(
    string Id,
    string Name,
    string Description,
    string Photo
);
