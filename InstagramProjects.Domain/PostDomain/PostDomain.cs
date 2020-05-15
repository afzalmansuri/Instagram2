using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;
using InstagramProjects.BoundedContext.SqlContext;
using Microsoft.Data.SqlClient;
using RxWeb.Core.Data;
using InstagramProjects.Models.ViewModels;

namespace InstagramProjects.Domain.PostModule
{
    public class PostDomain : IPostDomain
    {
        public PostDomain(IPostUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;

        }

        public async Task<object> GetAsync(Post parameters)
        {
            return await Uow.Repository<Post>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(Post parameters)
        {
            var val1 = await Uow.Repository<InstaUser>().SingleOrDefaultAsync(t => t.UserPrivacyId == 1 && t.InstaUserId == parameters.InstaUserId);
            if (val1 != null)
            {
                return await Uow.Repository<Post>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);

            }
            else
            {
                return ("The Account Is Private");
            }
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Post entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Post entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Post entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Post entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Post parameters)
        {
            return ValidationMessages;
        }

        public async Task DeleteAsync(Post parameters)
        {
            /*var UserPost = await Uow.Repository<Post>().FindByAsync(t => t.PostId == parameters.PostId);*/

            /* var UserPost = Uow.Repository<Post>().FindByKey(parameters.PostId);*/
            /*await Uow.RegisterDeletedAsync(UserPost);
            await Uow.CommitAsync();*/
            

                 var spParameters = new SqlParameter[1];
            spParameters[0] = new SqlParameter() { ParameterName = "postid", Value = parameters.PostId };
            

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spForDeletePost", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception)
            {
                 DbContextManager.RollbackTransaction();
            }

            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostDomain : ICoreDomain<Post, Post> { }
}
