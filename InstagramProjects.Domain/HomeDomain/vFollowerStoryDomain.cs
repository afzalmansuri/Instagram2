using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.HomeModule
{
    public class vFollowerStoryDomain : IvFollowerStoryDomain
    {
        public vFollowerStoryDomain(IHomeUow uow) {
            this.Uow = uow;
        }

        public async Task<object> GetAsync(vFollowerStory parameters)
        {
            return await Uow.Repository<vFollowerStory>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(vFollowerStory parameters)
        {
            return await Uow.Repository<vFollowerStory>().FindByAsync(t => t.FollowBy == parameters.FollowBy);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(vFollowerStory entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(vFollowerStory entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(vFollowerStory entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(vFollowerStory entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(vFollowerStory parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(vFollowerStory parameters)
        {
            throw new NotImplementedException();
        }

        public IHomeUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IvFollowerStoryDomain : ICoreDomain<vFollowerStory, vFollowerStory> { }
}
