using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
    class PurcpManagerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IPurcpManagerView _view;

        public PurcpManagerPresenter(IKernel kernel, IPurcpManagerView view)
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
