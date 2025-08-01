using System.Security.Claims;
using System.Security.Principal;

namespace SampleStore.Web.Infrustructure.Authentication
{
    public static class IdentityExtensions
    {
        public static UserClaims GetUserClaims(this IIdentity identity)
        {
            return new UserClaims
            {
                Id = identity.GetUserId()
            };
        }

        public static Guid GetUserId(this IIdentity identity)
        {
            if(identity is ClaimsIdentity claimsIdentity)
            {
                var userId = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier)!.Value;
                return Guid.Parse(userId);
            }
            throw new Exception("Invalid identity");
        }
    }
}
