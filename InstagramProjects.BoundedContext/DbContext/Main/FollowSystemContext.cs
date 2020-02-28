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
    public class FollowSystemContext : BaseBoundedContext, IFollowSystemContext
    {
        public FollowSystemContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<vFollower> vFollowers { get; set; }
		public DbSet<Follower> Followers { get; set; }
		public DbSet<vFollower> vFollower { get; set; }
		public DbSet<vFollowing> vFollowing { get; set; }
            #endregion DbSets


    }


    public interface IFollowSystemContext : IDbContext
    {
    }
}

