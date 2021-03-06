using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using InstagramProjects.Infrastructure.Security;
using InstagramProjects.Models.Main;
using InstagramProjects.Models.ViewModels;
using InstagramProjects.UnitOfWork.Main;
using RxWeb.Core.Security.Cryptography;
using System;
using System.Linq;
using System.Threading.Tasks;
using RxWeb.Core.Security.Filters;

namespace InstagramProjects.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private ILoginUow LoginUow { get; set; }
        private IApplicationTokenProvider ApplicationTokenProvider { get; set; }
        private IPasswordHash PasswordHash { get; set; }

        public AuthenticationController(ILoginUow loginUow, IApplicationTokenProvider tokenProvider, IPasswordHash passwordHash)
        {
            this.LoginUow = loginUow;
            ApplicationTokenProvider = tokenProvider;
            PasswordHash = passwordHash;
        }

        [HttpGet]
        [AllowAnonymous]
        [AllowRequest(MaxRequestCountPerIp = 100)]
        public async Task<IActionResult> Get()
        {
          //  var token = await ApplicationTokenProvider.GetTokenAsync(new InstaUser { InstaUserId = 0});
            return Ok(0);
        }

        [HttpPost]
        /*[AllowAnonymousUser]*/
        [AllowAnonymous]
        public async Task<IActionResult> Post(AuthenticationModel authentication)
        {
            var user = await LoginUow.Repository<InstaUser>().SingleOrDefaultAsync(t => (t.InstaUserName == authentication.InstaUserName || t.InstaUserEmail == authentication.InstaUserName || t.InstaUserMobileNumber == authentication.InstaUserName));
            if (user != null && PasswordHash.VerifySignature(authentication.InstaUserPassword, user.InstaUserPassword, user.Salt))
            {
                var token = await ApplicationTokenProvider.GetTokenAsync(user);
                user.token = token;
                return Ok(user);
            }
            else
                return Ok("Invalid");
        }
    }
}

