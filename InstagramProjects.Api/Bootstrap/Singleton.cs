using Microsoft.Extensions.DependencyInjection;
using InstagramProjects.Infrastructure.Singleton;
using InstagramProjects.BoundedContext.Singleton;
using RxWeb.Core.Data;

namespace InstagramProjects.Api.Bootstrap
{
    public static class Singleton
    {
        public static void AddSingletonService(this IServiceCollection serviceCollection)
        {
            #region Singleton
            serviceCollection.AddSingleton<ITenantDbConnectionInfo, TenantDbConnectionInfo>();
            serviceCollection.AddSingleton(typeof(UserAccessConfigInfo));
            #endregion Singleton
        }

    }
}




