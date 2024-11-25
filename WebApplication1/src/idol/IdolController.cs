using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.idol;

[ApiController]
[Route("[controller]")]
public class IdolController(IdolService idolService) : ControllerBase
{
    [HttpGet(Name = "GetIdols")]
    public async Task<IEnumerable<IdolResponse>> Get()
    {
        return await idolService.GetIdols();
    }

    [HttpGet("{idolId:guid}", Name = "GetIdolById")]
    public async Task<IdolResponse> GetById(Guid idolId)
    {
        return await idolService.GetIdolById(idolId);
    }
}
