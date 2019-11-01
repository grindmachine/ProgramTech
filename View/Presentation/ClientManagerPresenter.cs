using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    public class ClientManagerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerView _view;

        public ClientManagerPresenter(IKernel kernel, IClientManagerView view)
        {
            _kernel = kernel;
            _view = view;

            _view.addOrder += () => CreateNewOrder();
            _view.lookOrder += () => ShowOrders();
        }

        private void CreateNewOrder()
        {

        }

        private void ShowOrders()
        {

        }

        public void Run()
        {
            _view.Show();
        }
    }
}
