using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ninject;
using Presentation;
using View.Storekeeper;
using Model;

namespace View
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Ninject.StandardKernel kernel = new StandardKernel();
            kernel.Bind<ApplicationContext>().ToConstant(new ApplicationContext());
            kernel.Bind<ISignInView>().To<SignInView>();
            kernel.Bind<IClientManagerView>().To<ClientManagerView>();
            kernel.Bind<IPurcpManagerView>().To<PurcpManagerView>();
            kernel.Bind<IBookerView>().To<BookerView>();
            kernel.Bind<ICourierView>().To<CourierView>();
            kernel.Bind<IStorekeeperView>().To<StorekeeperView>();
            kernel.Bind<IStorekeeperSearchIncomingInvoiceView>().To<StorekeeperSearchIncomingInvoiceView>();
            kernel.Bind<IStorekeeperSearchSalesInvoiceView>().To<StorekeeperSearchSalesInvoiceView>();
            kernel.Bind<IClientManagerAddOrderView>().To<ClientManagerAddOrderView>();
            kernel.Bind<IClientManagerAddOrderSecondStepView>().To<ClientManagerAddOrderSecondStepView>();
            kernel.Bind<IModel>().To<Model.Model>();
            kernel.Bind<IClientOrder>().To<ClientOrder>();
            kernel.Bind<IClientManagerInspectOrderView>().To<ClientManagerInspectOrderView>();
           

            kernel.Bind<CourierPresenter>().ToSelf();
            kernel.Bind<BookerPresenter>().ToSelf();
            kernel.Bind<PurcpManagerPresenter>().ToSelf();
            kernel.Bind<SignInPresenter>().ToSelf();
            kernel.Bind<ClientManagerPresenter>().ToSelf();
            kernel.Bind<StorekeeperPresenter>().ToSelf();
            kernel.Bind<StorekeeperSeacrhIncomingInvoicePresenter>().ToSelf();
            kernel.Bind<StorekeeperSearchSalesInvoicePresenter>().ToSelf();
            kernel.Bind<ClientManagerAddOrderPresenter>().ToSelf();
            kernel.Bind<ClientManagerInspectOrderPresenter>().ToSelf();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            kernel.Get<SignInPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());  
        }
    }
}
