using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.StoryModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.StoryModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class StoriesController : BaseDomainController<Story, Story>

    {
        public StoriesController(IStoryDomain domain):base(domain) {}

    }
}
