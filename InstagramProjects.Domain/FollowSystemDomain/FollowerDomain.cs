using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.FollowSystemModule
{
    public class FollowerDomain : IFollowerDomain
    {
        public FollowerDomain(IFollowSystemUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Follower parameters)
        {
            throw new NotImplementedException();
        }

        public Task<object> GetBy(Follower parameters)
        {
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Follower entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Follower entity)
        {
            var count = Uow.Repository<Follower>().Count(t => t.FollowBy == entity.FollowBy && t.FollowTo == entity.FollowTo);
            if (count == 0)
            {
                await Uow.RegisterNewAsync(entity);
                await Uow.CommitAsync();
            }
        }

        public HashSet<string> UpdateValidation(Follower entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Follower entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Follower parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Follower parameters)
        {
            throw new NotImplementedException();
        }

        public IFollowSystemUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IFollowerDomain : ICoreDomain<Follower, Follower> { }
}
