using Ninject;
using View;
namespace Presentation
{
    public class StorekeeperPresenter : IPresenter
    {
        IKernel _kernel;
        IStorekeeperView _view;

        public StorekeeperPresenter(IKernel kernel, IStorekeeperView view)
        {
            _kernel = kernel;
            _view = view;
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
