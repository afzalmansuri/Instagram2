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
    public class PostLikeDomain : IPostLikeDomain
    {
        public PostLikeDomain(IPostUow uow,IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(PostLike parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(PostLike parameters)
        {
            return await Uow.Repository<PostLike>().FindByAsync(t => t.PostId == parameters.PostId);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostLike entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostLike entity)
        {
            var count = Uow.Repository<PostLike>().Count(a => a.LikedById == entity.LikedById && a.PostId == entity.PostId);
            if (count == 0)
            {
                await DbContextManager.BeginTransactionAsync();

                var spParameters = new SqlParameter[2];
                spParameters[0] = new SqlParameter() { ParameterName = "LikebyId", Value = entity.LikedById };
                spParameters[1] = new SqlParameter() { ParameterName = "PostId", Value = entity.PostId };


                await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertLikeAndLog ", spParameters);
                try
                {
                    await DbContextManager.CommitAsync();
                }
                catch (Exception)
                {
                    DbContextManager.RollbackTransaction();
                }


                /* await Uow.RegisterNewAsync(entity);
                 await Uow.CommitAsync();*/
            }
        }

        public HashSet<string> UpdateValidation(PostLike entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostLike entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostLike parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(PostLike parameters)
        {
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostLikeDomain : ICoreDomain<PostLike, PostLike> { }
}
