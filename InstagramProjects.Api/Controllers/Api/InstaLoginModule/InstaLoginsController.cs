using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.InstaLoginModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;
using Microsoft.AspNetCore.Authorization;
using InstagramProjects.Models.ViewModels;

namespace InstagramProjects.Api.Controllers.InstaLoginModule
{
    [ApiController]
    [Route("api/[controller]")]
	[AllowAnonymous]
	public class InstaLoginsController : BaseDomainController<InstaUser1, InstaUser1>

    {
        public InstaLoginsController(IInstaLoginDomain domain):base(domain) {}

    }
}
