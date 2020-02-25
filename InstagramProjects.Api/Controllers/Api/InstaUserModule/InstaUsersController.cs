using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.InstaUserModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.InstaUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class InstaUsersController : BaseDomainController<InstaUser, InstaUser>

    {
        public InstaUsersController(IInstaUserDomain domain):base(domain) {}

    }
}
