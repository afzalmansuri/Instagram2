using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RxWeb.Core;
using InstagramProjects.UnitOfWork.Main;
using InstagramProjects.Models.Main;

namespace InstagramProjects.Domain.StoryModule
{
    public class ViewStoryDomain : IViewStoryDomain
    {
        public ViewStoryDomain(IStoriesUow uow) {
            this.Uow = uow;
        }

        public Task<object> GetAsync(ViewStory parameters)
        {
            throw new NotImplementedException();
        }

        public async Task<object> GetBy(ViewStory parameters)
        {
            var result = await Uow.Repository<Story>().FindByAsync(t => t.StoryId == parameters.StoryId);
            throw new NotImplementedException();
        }
        

        public HashSet<string> AddValidation(ViewStory entity)
        {
            return ValidationMessages;
        }

        public async Task AddAsync(ViewStory entity)
        {
            await Uow.RegisterNewAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> UpdateValidation(ViewStory entity)
        {
            return ValidationMessages;
        }

        public async Task UpdateAsync(ViewStory entity)
        {
            await Uow.RegisterDirtyAsync(entity);
            await Uow.CommitAsync();
        }

        public HashSet<string> DeleteValidation(ViewStory parameters)
        {
            return ValidationMessages;
        }

        public Task DeleteAsync(ViewStory parameters)
        {
            throw new NotImplementedException();
        }

        public IStoriesUow Uow { get; set; }

        private HashSet<string> ValidationMessages { get; set; } = new HashSet<string>();
    }

    public interface IViewStoryDomain : ICoreDomain<ViewStory, ViewStory> { }
}
