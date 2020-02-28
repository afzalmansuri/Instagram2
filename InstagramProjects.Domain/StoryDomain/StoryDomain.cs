using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.StoryModule
{
    public class StoryDomain : IStoryDomain
    {
        public StoryDomain(IStoriesUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(Story parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(Story parameters)
        {
            var result = await Uow.Repository<Story>().FindByAsync(t => t.InstaUserId == parameters.InstaUserId);
            return Task.FromResult(result);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(Story entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(Story entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(Story entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(Story entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(Story parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(Story parameters)
        {
            throw new NotImplementedException();
        }

        public IStoriesUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IStoryDomain : ICoreDomain<Story, Story> { }
}
