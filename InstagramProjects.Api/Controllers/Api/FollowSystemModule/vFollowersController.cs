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
    public class vFollowersController : BaseDomainController<vFollower, vFollower>

    {
        public vFollowersController(IvFollowerDomain domain):base(domain) {}

    }
}
