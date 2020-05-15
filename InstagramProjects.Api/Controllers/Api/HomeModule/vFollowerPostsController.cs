using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.HomeModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace InstagramProjects.Api.Controllers.HomeModule
{
    [ApiController]
    [Route("api/[controller]")]
    //[AllowAnonymous]
    public class vFollowerPostsController : BaseDomainController<vFollowerPost, vFollowerPost>

    {
        public vFollowerPostsController(IvFollowerPostDomain domain):base(domain) {}

    }
}
