using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.PostModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace InstagramProjects.Api.Controllers.PostModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
    public class PostShareController : BaseDomainController<PostShare, PostShare>

    {
        public PostShareController(IPostShareDomain domain):base(domain) {}

    }
}
