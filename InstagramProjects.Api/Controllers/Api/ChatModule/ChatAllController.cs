using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.ChatModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.ChatModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class ChatAllController : BaseDomainController<Chat, Chat>

    {
        public ChatAllController(IChatAllDomain domain):base(domain) {}

    }
}
