using Model;
using Ninject;
using Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.Presentation.ClientManager
{
    class ClientManagerAddOrderSecondStepPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderSecondStepView _view;
        private IClientOrder _order;

        public ClientManagerAddOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view)
        {
            _kernel = kernel;
            _view = view;

            _view.AddProduct += () => addProduct();
            _view.Back += () => Back();
            _view.Cancel += () => Cancel();
        }

        public ClientManagerAddOrderSecondStepPresenter(IKernel kernel, IClientManagerAddOrderSecondStepView view, IClientOrder order) : this(kernel, view)
        {
            _order = order;
        }

        private void Cancel()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }
        
        private void Back()
        {
            new ClientManagerAddOrderPresenter(_kernel, new ClientManagerAddOrderView(_kernel.Get<ApplicationContext>()), _order).Run();
            _view.Close();
        }

        private void addProduct()
        {

        }
        public void Run()
        {
            _view.Show();
        }
    }
}
