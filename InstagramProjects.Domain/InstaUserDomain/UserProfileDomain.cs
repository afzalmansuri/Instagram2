using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.InstaUserModule
{
    public class UserProfileDomain : IUserProfileDomain
    {
        public UserProfileDomain(IUserProfileUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vUserProfile parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vUserProfile parameters)
        {
            return await Uow.Repository<vUserProfile>().SingleOrDefaultAsync(t => t.InstaUserId == parameters.InstaUserId);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vUserProfile entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vUserProfile entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vUserProfile entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vUserProfile entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vUserProfile parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vUserProfile parameters)
        {
            throw new NotImplementedException();
        }

        public IUserProfileUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IUserProfileDomain : ICoreDomain<vUserProfile, vUserProfile> { }
}
