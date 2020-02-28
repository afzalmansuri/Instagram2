using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;
using InstagramProjects.Models.ViewModels;

namespace InstagramProjects.Domain.InstaLoginModule
{
    public class InstaLoginDomain : IInstaLoginDomain
    {
        public InstaLoginDomain(IInstaUserUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vInstaUser parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vInstaUser parameters)
        {
            return await Uow.Repository<vInstaUser>().FindByAsync(t => t.InstaUserName == parameters.InstaUserName || t.InstaUserEmail== parameters.InstaUserEmail || t.InstaUserMobileNumber==parameters.InstaUserMobileNumber && t.InstaUserPassword==t.InstaUserPassword);
            
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vInstaUser entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vInstaUser entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vInstaUser entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vInstaUser entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vInstaUser parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vInstaUser parameters)
        {
            throw new NotImplementedException();
        }

        public IInstaUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IInstaLoginDomain : ICoreDomain<vInstaUser,vInstaUser> { }
}
