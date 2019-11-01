using System;

namespace Presentation
{
    public interface IPurcpManagerView : IView
    {
        //Просмотреть информацию о заказанных товарах
        event Action ViewInfoOrderProd;
        //Добавить новый заказ
        event Action AddOrder;
        //Просмотреть информацию о поставщике
        event Action ViewInfoProvider;
        //Добавить поставщика
        event Action AddProvider;
        //Удалить поставщика
        event Action RemoveProvider;
        //Просмотреть информацию о закончившихся и заканчивающихся товарах
        event Action ViewInfoEndedProd;
    }
}
