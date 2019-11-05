using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Ninject;
using Model;

namespace Presentation
{
    class StorekeeperSearchSalesInvoicePresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IStorekeeperSearchInvoiceView _view;
        private readonly IModel _model;

        public StorekeeperSearchSalesInvoicePresenter(IKernel kernel, IStorekeeperSearchSalesInvoiceView view, IModel model)
        {
            _kernel = kernel;
            _view = view;
            _model = model;

            _view.search += () => SearchInvoice();
            _view.ShowInvoiceContent += () => ShowInvoiceContent();
            _view.ConfirmAdmission += () => ConfirmAdmission();
            _view.Back += () => Back();
        }

        private bool SearchInvoice()
        {
            int number = 0;
            try
            {
                number = int.Parse((_view.getNumberInvoice()));
            }
            catch (Exception e)
            {
                return false;
            }
            IBriefInvoiceInfo info = _model.findSalesInvoice(number);
            if (info != null)
            {
                _view.setName(info.getName());
                _view.setNumberInvoice(info.getNumber());
                _view.setCost(info.getCost());
                return true;
            }
            else
                return false;
        }

        private void ShowInvoiceContent()
        {

        }

        private void ConfirmAdmission()
        {

        }

        private void Back()
        {
            _kernel.Get<StorekeeperPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }
    }
}
