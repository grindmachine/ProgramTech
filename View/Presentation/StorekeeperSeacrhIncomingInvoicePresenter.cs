using System;
using Ninject;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
     class StorekeeperSeacrhIncomingInvoicePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IStorekeeperSearchIncomingInvoiceView _view;

        public StorekeeperSeacrhIncomingInvoicePresenter(IKernel kernel, IStorekeeperSearchIncomingInvoiceView view)
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
