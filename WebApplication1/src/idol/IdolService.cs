using Microsoft.EntityFrameworkCore;
using WebApplication1.shared.infrastructure;

namespace WebApplication1.idol;

public class IdolService(AppDbContext appDbContext)
{
    public async Task<IEnumerable<IdolResponse>> GetIdols()
    {
        var idols = await appDbContext.Idols.ToListAsync();
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

    public async Task<IdolResponse> GetIdolById(Guid idolId)
    {
        var idol = await appDbContext.Idols.Where(idol => idol.Id == idolId).FirstAsync();
        var idolResponse = new IdolResponse(
            idol.Id.ToString(),
            idol.GroupId.ToString(),
            idol.Name,
            idol.RealName,
            idol.About,
            idol.Photo
        );

        return idolResponse;
    }
}

public record IdolResponse(
    string Id,
    string GroupId,
    string Name,
    string RealName,
    string About,
    string Photo
);
