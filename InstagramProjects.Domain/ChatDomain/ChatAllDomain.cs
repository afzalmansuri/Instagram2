using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.ChatModule
{
    public class ChatAllDomain : IChatAllDomain
    {
        public ChatAllDomain(IChatUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Chat parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(Chat parameters)
        {
            var chatlist = await Uow.Repository<Chat>().FindByAsync(t => t.SenderId == parameters.SenderId);
            return await Task.FromResult(chatlist);
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
    }

    public interface IChatAllDomain : ICoreDomain<Chat,Chat> { }
}
