using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.InstaUserModule
{
    public class InstaUserDomain : IInstaUserDomain
    {
        public InstaUserDomain(IInstaUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(InstaUser parameters)
        {
            return await Uow.Repository<InstaUser>().AllAsync();
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(InstaUser parameters)
        {
            return await Uow.Repository<InstaUser>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(InstaUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(InstaUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(InstaUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(InstaUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(InstaUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(InstaUser parameters)
        {
            throw new NotImplementedException();
        }

        public IInstaUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IInstaUserDomain : ICoreDomain<InstaUser, InstaUser> { }
}
