using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.InstaUserModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace InstagramProjects.Api.Controllers.InstaUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	//[AllowAnonymous]
	public class UserProfileController : BaseDomainController<vUserProfile, vUserProfile>

    {
        public UserProfileController(IUserProfileDomain domain):base(domain) {}

    }
}
