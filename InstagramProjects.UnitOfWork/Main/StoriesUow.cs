using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class StoriesUow : BaseUow, IStoriesUow
    {
        public StoriesUow(IStoriesContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IStoriesUow : ICoreUnitOfWork { }
}


