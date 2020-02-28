using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.FollowSystemModule
{
    public class vFollowerDomain : IvFollowerDomain
    {
        public vFollowerDomain(IFollowSystemUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(vFollower parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vFollower parameters)
        {
            return await Uow.Repository<vFollower>().FindByAsync(t => t.FollowTo == parameters.FollowTo);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vFollower entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vFollower entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vFollower entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vFollower entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vFollower parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vFollower parameters)
        {
            throw new NotImplementedException();
        }

        public IFollowSystemUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvFollowerDomain : ICoreDomain<vFollower, vFollower> { }
}
