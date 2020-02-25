using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.InstaUserModule
{
    public class UserDetailDomain : IUserDetailDomain
    {
        public UserDetailDomain(IInstaUserUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(UserDetail parameters)
        {
            return await Uow.Repository<UserDetail>().AllAsync();
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(UserDetail parameters)
        {
            return await Uow.Repository<UserDetail>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId); 
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(UserDetail entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(UserDetail entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(UserDetail entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(UserDetail entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(UserDetail parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(UserDetail parameters)
        {
            throw new NotImplementedException();
        }

        public IInstaUserUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserDetailDomain : ICoreDomain<UserDetail, UserDetail> { }
}
