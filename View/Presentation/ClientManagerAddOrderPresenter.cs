using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    class ClientManagerAddOrderPresenter : IClientManagerAddOrderPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderView _view;

        public ClientManagerAddOrderPresenter(IKernel kernel, IClientManagerAddOrderView view)
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
