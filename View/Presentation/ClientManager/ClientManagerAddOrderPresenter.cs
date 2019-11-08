using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Ninject;
using View;
using View.Presentation.ClientManager;

namespace Presentation
{
    class ClientManagerAddOrderPresenter : IClientManagerAddOrderPresenter
    {
        private readonly IKernel _kernel;
        private readonly IClientManagerAddOrderView _view;
        private IClientOrder _order;

        public ClientManagerAddOrderPresenter(IKernel kernel, IClientManagerAddOrderView view, IClientOrder order) : this(kernel, view)
        {
            _order = order;
            setOrderInfo();

        }

        public ClientManagerAddOrderPresenter(IKernel kernel, IClientManagerAddOrderView view)
        {
            _kernel = kernel;
            _view = view;

            _view.Back += () => back();
            _view.NextStep += () => NextStep();
        }

        private void back()
        {
            _kernel.Get<ClientManagerPresenter>().Run();
            _view.Close();
        }
        public void Run()
        {
            _view.Show();
        }

        private void NextStep()
        {
            if (_order == null)
                _order = _kernel.Get<IClientOrder>();

            _order.Name = _view.getName();
            _order.Surname = _view.getSurname();
            _order.Patronymic = _view.getPatronymic();
            _order.PhoneNumber = _view.getPhoneNumber();
            _order.EmailAddress = _view.getEmailAddress();
            _order.City = _view.getCity();
            _order.Street = _view.getStreet();
            _order.HouseNumber = _view.getHouseNumber();
            _order.Pavilion = _view.getPavilion();
            _order.Flat = _view.getFlat();

            new ClientManagerAddOrderSecondStepPresenter(_kernel, _kernel.Get<IClientManagerAddOrderSecondStepView>(), _order).Run();
            _view.Close();
        }

        private void setOrderInfo()
        {
            _view.setName(_order.Name);
            _view.setSurname(_order.Surname);
            _view.setPatronymic(_order.Patronymic);
            _view.setPhoneNumber(_order.PhoneNumber);
            _view.setEmailAddress(_order.EmailAddress);
            _view.setCity(_order.City);
            _view.setStreet(_order.Street);
            _view.setHouseNumber(_order.HouseNumber);
            _view.setPavilion(_order.Pavilion);
            _view.setFlat(_order.Flat);
        }
    }
}
