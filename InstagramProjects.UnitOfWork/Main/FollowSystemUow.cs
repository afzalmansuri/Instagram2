using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class FollowSystemUow : BaseUow, IFollowSystemUow
    {
        public FollowSystemUow(IFollowSystemContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IFollowSystemUow : ICoreUnitOfWork { }
}


