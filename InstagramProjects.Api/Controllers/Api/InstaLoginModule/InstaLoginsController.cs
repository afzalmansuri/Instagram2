using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.InstaLoginModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.InstaLoginModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class InstaLoginsController : BaseDomainController<vInstaUser,vInstaUser>

    {
        public InstaLoginsController(IInstaLoginDomain domain):base(domain) {}

    }
}
