using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.ChatModule
{
    public class ChatWithAllUserDomain : IChatWithAllUserDomain
    {
        public ChatWithAllUserDomain(IChatUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vChatWithAllUser parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vChatWithAllUser parameters)
        {
            var chatlist = await Uow.Repository<vChatWithAllUser>().FindByAsync(t => t.SenderId == parameters.SenderId );
            return await Task.FromResult(chatlist);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vChatWithAllUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vChatWithAllUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vChatWithAllUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vChatWithAllUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vChatWithAllUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vChatWithAllUser parameters)
        {
            throw new NotImplementedException();
        }

        public IChatUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IChatWithAllUserDomain : ICoreDomain<vChatWithAllUser, vChatWithAllUser> { }
}
