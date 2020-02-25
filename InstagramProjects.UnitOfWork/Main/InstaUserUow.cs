using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class InstaUserUow : BaseUow, IInstaUserUow
    {
        public InstaUserUow(IInstaUserContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IInstaUserUow : ICoreUnitOfWork { }
}


