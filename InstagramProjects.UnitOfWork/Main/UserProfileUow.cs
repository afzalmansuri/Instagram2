using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class UserProfileUow : BaseUow, IUserProfileUow
    {
        public UserProfileUow(IUserProfileContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IUserProfileUow : ICoreUnitOfWork { }
}


