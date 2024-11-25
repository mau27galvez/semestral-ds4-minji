using Microsoft.AspNetCore.Identity;

namespace WebApplication1.user;

public class User : IdentityUser<Guid>
{
    public string? Initials { get; init; }
}
