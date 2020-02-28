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
    public class ActivityLogContext : BaseBoundedContext, IActivityLogContext
    {
        public ActivityLogContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vActivityLog> vActivityLog { get; set; }
            		public DbSet<vFollowerPost> vFollowerPost { get; set; }
            #endregion DbSets



    }


    public interface IActivityLogContext : IDbContext
    {
    }
}

