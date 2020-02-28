using Microsoft.AspNetCore.Mvc;
using System.Linq;
using InstagramProjects.Domain.ActivityLogModule;
using InstagramProjects.Models.Main;
using RxWeb.Core.AspNetCore;
using RxWeb.Core.Security.Authorization;

namespace InstagramProjects.Api.Controllers.ActivityLogModule
{
    [ApiController]
    [Route("api/[controller]")]
	
	public class vActivityLogController : BaseDomainController<vActivityLog, vActivityLog>

    {
        public vActivityLogController(IvActivityLogDomain domain):base(domain) {}

    }
}
