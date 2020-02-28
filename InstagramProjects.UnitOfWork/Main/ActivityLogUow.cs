using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class ActivityLogUow : BaseUow, IActivityLogUow
    {
        public ActivityLogUow(IActivityLogContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IActivityLogUow : ICoreUnitOfWork { }
}


