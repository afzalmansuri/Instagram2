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
    public class PostContext : BaseBoundedContext, IPostContext
    {
        public PostContext(MainSqlDbContext sqlDbContext,  IOptions<DatabaseConfig> databaseConfig, IHttpContextAccessor contextAccessor,ITenantDbConnectionInfo tenantDbConnection): base(sqlDbContext, databaseConfig.Value, contextAccessor,tenantDbConnection){ }

            #region DbSets
            		public DbSet<Post> Posts { get; set; }
		public DbSet<PostLike> PostLikes { get; set; }
		public DbSet<PostComment> PostComments { get; set; }
		public DbSet<PostShare> PostShares { get; set; }
            		public DbSet<PostTag> PostTags { get; set; }
            #endregion DbSets



    }


    public interface IPostContext : IDbContext
    {
    }
}

