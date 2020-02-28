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
	
	public class PostTagController : BaseDomainController<PostTag, PostTag>

    {
        public PostTagController(IPostTagDomain domain):base(domain) {}

    }
}