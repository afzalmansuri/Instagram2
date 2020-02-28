using RxWeb.Core.Data;
using InstagramProjects.BoundedContext.Main;

namespace InstagramProjects.UnitOfWork.Main
{
    public class ChatUow : BaseUow, IChatUow
    {
        public ChatUow(IChatContext context, IRepositoryProvider repositoryProvider) : base(context, repositoryProvider) { }
    }

    public interface IChatUow : ICoreUnitOfWork { }
}


