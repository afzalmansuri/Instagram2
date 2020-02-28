using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class HomeUow : BaseUow, IHomeUow
    {
        public HomeUow(IHomeContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IHomeUow : ICoreUnitOfWork { }
}


