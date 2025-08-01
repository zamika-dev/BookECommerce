using Microsoft.AspNetCore.Mvc;
using SampleStore.Web.Infrustructure;
using SampleStore.Web.Infrustructure.Authentication;

namespace SampleStore.Web.Controllers
{
    public class BaseController : Controller
    {
        private UserClaims? _userClaims;

        public UserClaims? UserClaims
        {
            get
            {
                if (_userClaims != null)
                    return _userClaims;

                if (HttpContext.User.Identity?.IsAuthenticated != true)
                    return null;

                _userClaims = HttpContext.User.Identity.GetUserClaims();
                return _userClaims;
            }
        }

        protected bool IsAuthenticated => User.Identity?.IsAuthenticated == true;
    }
}
