using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.ChatModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;

namespace InstagramProjects.Api.Controllers.ChatModule
{
    [ApiController]
    [Route("api/[controller]")]
    [AllowAnonymous]
	
	public class ChatWithAllUsersController : BaseDomainController<vChatWithAllUser, vChatWithAllUser>

    {
        public ChatWithAllUsersController(IChatWithAllUserDomain domain):base(domain) {}

    }
}
