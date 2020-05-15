using InstagramProjects.Infrastructure.Singleton;
using InstagramProjects.Models.Main;
using InstagramProjects.Models.ViewModels;
using InstagramProjects.UnitOfWork.Main;
using Microsoft.AspNetCore.Http;
using RxWeb.Core.Security;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace InstagramProjects.Infrastructure.Security
{
    public class ApplicationTokenProvider : IApplicationTokenProvider
    {
        private ILoginUow LoginUow { get; set; }
        private UserAccessConfigInfo UserAccessConfig { get; set; }
        private IJwtTokenProvider TokenProvider { get; set; }

        private IUserClaim UserClaim { get; set; }

        private IHttpContextAccessor ContextAccessor { get; set; }

        public ApplicationTokenProvider(IJwtTokenProvider tokenProvider, UserAccessConfigInfo userAccessConfig, ILoginUow loginUow, IUserClaim userClaim, IHttpContextAccessor contextAccessor)
        {
            TokenProvider = tokenProvider;
            UserAccessConfig = userAccessConfig;
            LoginUow = loginUow;
            UserClaim = userClaim;
            ContextAccessor = contextAccessor;
        }
        public async Task<string> GetTokenAsync(InstaUser user)
        {
            var expirationTime = user.InstaUserId == 0 ? DateTime.UtcNow.AddDays(1) : DateTime.UtcNow.AddMinutes(30);
            var token = TokenProvider.WriteToken(new[]{
                new Claim(
                    ClaimTypes.NameIdentifier, user.InstaUserId.ToString()),
                new Claim(ClaimTypes.Anonymous, (user.InstaUserId == 0).ToString()),
                    new Claim(ClaimTypes.Email,user.InstaUserEmail),
                    new Claim(CustomClaimTypes.TenantId,user.InstaUserName)
                    }, "Web", "User", expirationTime);
            if (user.InstaUserId != 0) await UserAccessConfig.SaveTokenAsync(user.InstaUserId, "web", token, LoginUow);
            this.AddCookie(user, token.Key);
            return token.Value;
        }

        public async Task<string> RefereshTokenAsync(InstaUser user, UserConfig userConfig)
        {
            if (!string.IsNullOrEmpty(userConfig.LanguageCode))
            {
                var userRecord = await LoginUow.Repository<User>().SingleAsync(t => t.UserId == user.InstaUserId);
                userRecord.LanguageCode = userConfig.LanguageCode;
                await LoginUow.RegisterDirtyAsync<User>(userRecord);
                await LoginUow.CommitAsync();
            }
            await UserAccessConfig.RemoveTokenAsync(user.InstaUserId, userConfig.AudienceType, LoginUow);
            return await this.GetTokenAsync(user);
        }

        public async Task RemoveTokenAsync(UserConfig userConfig)
        {
            this.RemoveCookie();
            await UserAccessConfig.RemoveTokenAsync(UserClaim.UserId, userConfig.AudienceType, LoginUow);
        }


        private void AddCookie(InstaUser user, string value)
        {
            var cookieName = user.InstaUserId == 0 ? ANONYMOUS : REQUEST_IDENTITY;
            if (cookieName == REQUEST_IDENTITY && ContextAccessor.HttpContext.Request.Cookies.ContainsKey(ANONYMOUS))
                ContextAccessor.HttpContext.Response.Cookies.Delete(ANONYMOUS);
            ContextAccessor.HttpContext.Response.Cookies.Append(cookieName, value);
        }
        private void RemoveCookie() => ContextAccessor.HttpContext.Response.Cookies.Delete(REQUEST_IDENTITY);

        private const string REQUEST_IDENTITY = "request_identity";
        private const string ANONYMOUS = "anonymous";
    }

    public interface IApplicationTokenProvider
    {
        Task<string> GetTokenAsync(InstaUser user);

        Task<string> RefereshTokenAsync(InstaUser user, UserConfig userConfig);

        Task RemoveTokenAsync(UserConfig userConfig);
    }
}



