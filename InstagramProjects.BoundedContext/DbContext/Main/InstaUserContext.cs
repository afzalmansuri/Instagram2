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
    public class InstaUserContext : BaseBoundedContext, IInstaUserContext
    {
        public InstaUserContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<InstaUser> InstaUsers { get; set; }
		public DbSet<UserDetail> UserDetails { get; set; }
		public DbSet<UserPrivacy> UserPrivacys { get; set; }
		public DbSet<vEditProfile> vEditProfile { get; set; }

       
        		public DbSet<vInstaUser> vInstaUsers { get; set; }
            		
            #endregion DbSets




    }


    public interface IInstaUserContext : IDbContext
    {
    }
}

