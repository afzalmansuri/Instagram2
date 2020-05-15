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


namespace InstagramProjects.Domain.ChatModule
{
    public class ChatAllDomain : IChatAllDomain
    {
        public ChatAllDomain(IChatUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;
        }

        public Task<object> GetAsync(Chat parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(Chat parameters)
        {
           

            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[2];
            spParameters[0] = new SqlParameter() { ParameterName = "SenderId", Value = parameters.SenderId };
            spParameters[1] = new SqlParameter() { ParameterName = "RecieverId", Value = parameters.RecieverId };

           
            var result=await DbContextManager.StoreProc<StoreProcResult>("[dbo].vChats ", spParameters);

           
            
            return await Task.FromResult(result);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Chat entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Chat entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Chat entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Chat entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Chat parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Chat parameters)
        {
            throw new NotImplementedException();
        }

        public IChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IChatAllDomain : ICoreDomain<Chat,Chat> { }
}
