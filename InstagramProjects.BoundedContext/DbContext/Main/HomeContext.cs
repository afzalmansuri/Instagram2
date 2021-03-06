using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using InstagramProjects.BoundedContext.SqlContext;
using InstagramProjects.Models.Main;
using InstagramProjects.Models;
using InstagramProjects.BoundedContext.Singleton;
using RxWeb.Core.Data;
using RxWeb.Core.Data.Models;
using RxWeb.Core.Data.BoundedContext;

namespace InstagramProjects.BoundedContext.Main
{
    public class HomeContext : BaseBoundedContext, IHomeContext
    {
        public HomeContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vFollowerPost> vFollowerPost { get; set; }
            		public DbSet<vFollowerStory> vFollowerStories { get; set; }
            #endregion DbSets



    }


    public interface IHomeContext : IDbContext
    {
    }
}

