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

            _view.SearchPurchInvoice += () => SearchIncomingInvoice();
        }

        private void SearchIncomingInvoice()
        {
            _kernel.Get<StorekeeperSeacrhIncomingInvoicePresenter>().Run();
            _view.Close();

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
