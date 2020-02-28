using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class PostUow : BaseUow, IPostUow
    {
        public PostUow(IPostContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IPostUow : ICoreUnitOfWork { }
}


