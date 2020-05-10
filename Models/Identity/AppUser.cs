using Microsoft.AspNetCore.Identity;

namespace MyAppBack.Identity
{
  public class AppUser : IdentityUser
  {
    public string DisplayName { get; set; }
    public Address Address { get; set; }
  }
}