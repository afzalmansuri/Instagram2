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
            #endregion ContextService




            #region DomainService

            
            serviceCollection.AddScoped<IInstaUserDomain, InstaUserDomain>();
            
            serviceCollection.AddScoped<IUserDetailDomain, UserDetailDomain>();
            
            serviceCollection.AddScoped<IUserDetailDomain, UserDetailDomain>();
            
            serviceCollection.AddScoped<IUserDetailDomain, UserDetailDomain>();
            #endregion DomainService




        }
    }
}




