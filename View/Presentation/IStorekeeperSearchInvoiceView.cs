using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IStorekeeperSearchInvoiceView : IView, ISetInfoInvoiceForSearchInvoice, IBack
    {
        //Поиск накладной по номеру
        event Search search;
        //Отображение содержимого накладной
        event Action ShowInvoiceContent;
        //Подтверждение приёма/передачи заказа от/к поставщика/клиенту
        event Action ConfirmAdmission;
        string getNumberInvoice();
    }

    public delegate bool Search();
}
