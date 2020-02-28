using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.FollowSystemModule
{
    public class vFollowingDomain : IvFollowingDomain
    {
        public vFollowingDomain(IFollowSystemUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vFollowing parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vFollowing parameters)
        {
            return await Uow.Repository<vFollowing>().FindByAsync(t => t.FollowBy == parameters.FollowBy);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vFollowing entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vFollowing entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vFollowing entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vFollowing entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vFollowing parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vFollowing parameters)
        {
            throw new NotImplementedException();
        }

        public IFollowSystemUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvFollowingDomain : ICoreDomain<vFollowing, vFollowing> { }
}
