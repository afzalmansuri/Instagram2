using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.FollowSystemModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.FollowSystemModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class FollowersController : BaseDomainController<Follower, Follower>

    {
        public FollowersController(IFollowerDomain domain):base(domain) {}

    }
}
