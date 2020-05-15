using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.FollowSystemModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace InstagramProjects.Api.Controllers.FollowSystemModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class vFollowingController : BaseDomainController<vFollowing, vFollowing>

    {
        public vFollowingController(IvFollowingDomain domain):base(domain) {}

    }
}
