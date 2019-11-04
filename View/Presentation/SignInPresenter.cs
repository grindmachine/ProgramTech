using Ninject;


namespace Presentation
{
    internal class SignInPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ISignInView _view;
        public SignInPresenter(IKernel kernel, ISignInView view)
        {
            _kernel = kernel;
            _view = view;

            _view.OpenClientManager += () => OpenClientManager();
            _view.OpenPurcрManager += () => OpenPurcpManager();
            _view.OpenBooker += () => OpenBooker();
            _view.OpenCourier += () => OpenCourier();
            _view.OpentStorekeeper += () => OpenStorekeeper();
        }

        public void Run()
        {
            _view.Show();
        }

        private void OpenClientManager()
        {
            
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

        private void OpenPurcpManager()
        {
            _kernel.Get<PurcpManagerPresenter>().Run();
            _view.Close();
        }

        private void OpenBooker()
        {
            _kernel.Get<BookerPresenter>().Run();
            _view.Close();
        }

        private void OpenCourier()
        {
            _kernel.Get<CourierPresenter>().Run();
            _view.Close();
        }

        private void OpenStorekeeper()
        {
            _kernel.Get<StorekeeperPresenter>().Run();
            _view.Close();
        }
    }
}
