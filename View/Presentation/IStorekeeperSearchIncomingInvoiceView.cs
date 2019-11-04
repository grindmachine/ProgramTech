using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    interface IStorekeeperSearchIncomingInvoiceView:IView
    {
        //Поиск накладной по номеру
        event Action Search;
        //Отображение содержимого накладной
        event Action ShowInvoiceContent;
        //Подтверждение приёма заказа от поставщика
        event Action ConfirmAdmission;
    }
}
