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
    public class ChatDomain : IChatDomain
    {
        public ChatDomain(IChatUow uow, IDbContextManager<MainSqlDbContext> dbContextManager) {
            this.Uow = uow;
            DbContextManager = dbContextManager;

        }

        public Task<object> GetAsync(ChatCustom parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(ChatCustom parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ChatCustom entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ChatCustom entity)
        {
            //var chat = new Chat
            //{
            //    SenderId = entity.SenderId,
            //    RecieverId = entity.RecieverId,
            //    ChatDetails = new List<ChatDetail>
            //    {
            //        new ChatDetail{
            //        MessageContent = entity.messageContent
            //        }
            //    }
            //};
            //Uow.RegisterNewAsync(chat);
            //Uow.CommitAsync();
            await Uow.Repository<Chat>().SingleOrDefaultAsync(a => a.SenderId == entity.SenderId && a.RecieverId == entity.RecieverId);

            await DbContextManager.BeginTransactionAsync();

            var spParameters = new SqlParameter[3];
            spParameters[0] = new SqlParameter() { ParameterName = "SenderId", Value = entity.SenderId };
            spParameters[1] = new SqlParameter() { ParameterName = "RecieverId", Value = entity.RecieverId };
            spParameters[2] = new SqlParameter() { ParameterName = "message", Value = entity.messageContent };

            await DbContextManager.StoreProc<StoreProcResult>("[dbo].spAddChatContent ", spParameters);
            try
            {
                await DbContextManager.CommitAsync();
            }
            catch (Exception)
            {
                DbContextManager.RollbackTransaction();
            }
        }

        public HashSet<string> UpdateValidation(ChatCustom entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ChatCustom entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ChatCustom parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ChatCustom parameters)
        {
            throw new NotImplementedException();
        }

        public IChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
        private IDbContextManager<MainSqlDbContext> DbContextManager { get; set; }
    }

    public interface IChatDomain : ICoreDomain<ChatCustom, ChatCustom> { }
}
