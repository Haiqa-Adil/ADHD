using Microsoft.AspNetCore.Identity;

namespace ADHD.UtilService
{
    public interface IAuthenticationToken
    {
       string CreateToken(IdentityUser user);
    }
}
