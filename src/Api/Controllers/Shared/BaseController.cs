using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Api.Controllers.Shared
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController : ControllerBase
    {
        protected Guid CurrentUserId
        {
            get
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                if (Guid.TryParse(userId, out Guid id))
                    return id;

                return Guid.Empty;
            }
        }
        protected string? CurrentUserName
        {
            get
            {
                return User.FindFirstValue(ClaimTypes.Name);
            }
        }
        protected string? CurrentUserEmail
        {
            get
            {
                return User.FindFirstValue(ClaimTypes.Email);
            }
        }
        protected bool IsAuthenticated()
        {
            return User.Identity?.IsAuthenticated ?? false;
        }
    }
}
