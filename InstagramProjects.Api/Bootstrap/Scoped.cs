#region Namespace
using Microsoft.Extensions.DependencyInjection;
using InstagramProjects.Infrastructure.Security;
using RxWeb.Core.Data;
using RxWeb.Core.Security;
using RxWeb.Core.Annotations;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.DbEntityAudit;
using InstagramProjects.BoundedContext.Main;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Domain.InstaUserModule;
          
            
            using InstagramProjects.Domain.InstaLoginModule;
           
            using InstagramProjects.Domain.PostModule;
            
            using InstagramProjects.Domain.ChatModule;
            using InstagramProjects.Domain.FollowSystemModule;
           
            using InstagramProjects.Domain.ActivityLogModule;
            using InstagramProjects.Domain.HomeModule;
            using InstagramProjects.Domain.StoryModule;
          
           
            #endregion Namespace




















namespace InstagramProjects.Api.Bootstrap
{
    public static class ScopedExtension
    {

        public static void AddScopedService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IRepositoryProvider, RepositoryProvider>();
            serviceCollection.AddScoped<ITokenAuthorizer, TokenAuthorizer>();
            serviceCollection.AddScoped<IModelValidation, ModelValidation>();
            serviceCollection.AddScoped<IAuditLog, AuditLog>();
            serviceCollection.AddScoped<IApplicationTokenProvider, ApplicationTokenProvider>();
            serviceCollection.AddScoped(typeof(IDbContextManager<>), typeof(DbContextManager<>));

            #region ContextService

            serviceCollection.AddScoped<ILoginContext, LoginContext>();
            serviceCollection.AddScoped<ILoginUow, LoginUow>();
                        serviceCollection.AddScoped<IInstaUserContext, InstaUserContext>();
            serviceCollection.AddScoped<IInstaUserUow, InstaUserUow>();
                       
                        serviceCollection.AddScoped<IPostContext, PostContext>();
            serviceCollection.AddScoped<IPostUow, PostUow>();
                        serviceCollection.AddScoped<IChatContext, ChatContext>();
            serviceCollection.AddScoped<IChatUow, ChatUow>();
                        serviceCollection.AddScoped<IFollowSystemContext, FollowSystemContext>();
            serviceCollection.AddScoped<IFollowSystemUow, FollowSystemUow>();
                        serviceCollection.AddScoped<IActivityLogContext, ActivityLogContext>();
            serviceCollection.AddScoped<IActivityLogUow, ActivityLogUow>();
                        serviceCollection.AddScoped<IHomeContext, HomeContext>();
            serviceCollection.AddScoped<IHomeUow, HomeUow>();
                        serviceCollection.AddScoped<IStoriesContext, StoriesContext>();
            serviceCollection.AddScoped<IStoriesUow, StoriesUow>();
               
                        serviceCollection.AddScoped<IUserProfileContext, UserProfileContext>();
            serviceCollection.AddScoped<IUserProfileUow, UserProfileUow>();
            #endregion ContextService













            #region DomainService

            
            serviceCollection.AddScoped<IInstaUserDomain, InstaUserDomain>();
            
            serviceCollection.AddScoped<IUserDetailDomain, UserDetailDomain>();
            
            serviceCollection.AddScoped<IUserDetailDomain, UserDetailDomain>();
            
            serviceCollection.AddScoped<IUserDetailDomain, UserDetailDomain>();
            
            serviceCollection.AddScoped<IInstaLoginDomain, InstaLoginDomain>();
            serviceCollection.AddScoped<IPostLikeDomain, PostLikeDomain>();
            
            serviceCollection.AddScoped<IPostCommentDomain, PostCommentDomain>();
           
            serviceCollection.AddScoped<IChatDomain, ChatDomain>();
            
            serviceCollection.AddScoped<IPostShareDomain, PostShareDomain>();
            
            serviceCollection.AddScoped<IPostTagDomain, PostTagDomain>();
            
            serviceCollection.AddScoped<IFollowerDomain, FollowerDomain>();
            
            serviceCollection.AddScoped<IvFollowerDomain, vFollowerDomain>();
            
            serviceCollection.AddScoped<IvFollowingDomain, vFollowingDomain>();
            
           
            
            serviceCollection.AddScoped<IvActivityLogDomain, vActivityLogDomain>();
            
            serviceCollection.AddScoped<IvFollowerPostDomain, vFollowerPostDomain>();
            
            serviceCollection.AddScoped<IvFollowerStoryDomain, vFollowerStoryDomain>();
            
            serviceCollection.AddScoped<IChatAllDomain, ChatAllDomain>();
            
            serviceCollection.AddScoped<IStoryDomain, StoryDomain>();
            
            serviceCollection.AddScoped<IViewStoryDomain, ViewStoryDomain>();
            
            
            
            serviceCollection.AddScoped<IPostDomain, PostDomain>();
            
            serviceCollection.AddScoped<IChatWithAllUserDomain, ChatWithAllUserDomain>();
            
            
            
            serviceCollection.AddScoped<IUserProfileDomain, UserProfileDomain>();
            #endregion DomainService








































        }
    }
}




