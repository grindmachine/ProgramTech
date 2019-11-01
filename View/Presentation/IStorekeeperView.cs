using System;

namespace Presentation
{
    public interface IStorekeeperView : IView
    {
        //Поиск приходной накладной
        event Action SearchPurchInvoice;
        //Поиск расходной накладной
        event Action SearchExprenseInvoice;
        //Просмотреть список несформированных заказов клиентов
        event Action ShowListClientPurch;
        //Просмотреть список несформированных заказов для курьеров
        event Action ShowListCourierPurch;
    }
}
