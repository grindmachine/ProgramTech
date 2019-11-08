using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    class ClientManagerInspectOrderPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerInspectOrderView _view;

        public ClientManagerInspectOrderPresenter(IKernel kernel, IClientManagerInspectOrderView view)
        {
            _kernel = kernel;
            _view = view;

            _view.Back += () => Back();
            _view.CancelOrder += () => CancelOrder();
            _view.EditOrder += () => EditOrder();
            _view.SearchOrder += () => SearchOrder();
        }

        private void Back()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }

        private void CancelOrder()
        {

        }

        private void EditOrder()
        {
        }

        private void SearchOrder()
        {

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
