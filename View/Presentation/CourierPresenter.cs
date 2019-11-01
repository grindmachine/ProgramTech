using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace Presentation
{
   public class CourierPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly ICourierView _view;

       public CourierPresenter(IKernel kernel, ICourierView view)
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
