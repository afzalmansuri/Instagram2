using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.PostModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.PostModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class PostLikesController : BaseDomainController<PostLike, PostLike>

    {
        public PostLikesController(IPostLikeDomain domain):base(domain) {}

    }
}
