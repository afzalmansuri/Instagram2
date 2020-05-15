using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.InstaUserModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;
using InstagramProjects.Models.ViewModels;

namespace InstagramProjects.Api.Controllers.InstaUserModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class InstaUsersController : BaseDomainController<InstaUser1, InstaUser1>

    {
        public InstaUsersController(IInstaUserDomain domain):base(domain) {}

    }
}
