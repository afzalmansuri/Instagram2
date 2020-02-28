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
    public class PostCommentDomain : IPostCommentDomain
    {
        public PostCommentDomain(IPostUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public async Task<object> GetAsync(PostComment parameters)
        {
            return await Uow.Repository<PostComment>().FindByAsync(t => t.PostId == parameters.PostId);
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(PostComment parameters)
        {
            return await Uow.Repository<PostComment>().FindByAsync(t => t.PostId == parameters.PostId);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(PostComment entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(PostComment entity)
        {
            var count = Uow.Repository<PostComment>().Count(a => a.CommentUserId == entity.CommentUserId && a.PostId == entity.PostId);

            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[3];
            spParameters[0] = new SqlParameter() { ParameterName = "PostId", Value = entity.PostId };
            spParameters[1] = new SqlParameter() { ParameterName = "Comment", Value = entity.Comment };
            spParameters[2] = new SqlParameter() { ParameterName = "CommentUserId", Value = entity.CommentUserId };


            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spInsertCommentInLog ", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(PostComment entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(PostComment entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(PostComment parameters)
        {
            return ValidationMessages;
        }

        public async  Task DeleteAsync(PostComment parameters)
        {
            var UserComment = Uow.Repository<PostComment>().FindByKey(parameters.PostCommentId);
            await Uow.RegisterDeletedAsync(UserComment);
            await Uow.CommitAsync();
            throw new NotImplementedException();
        }

        public IPostUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IPostCommentDomain : ICoreDomain<PostComment, PostComment> { }
}
