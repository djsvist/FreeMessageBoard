namespace FMB.Core.API.Models.Identity;

public class AuthRequest
{
    public string UserName { get; set; } = null!;
    public string Password { get; set; } = null!;
}