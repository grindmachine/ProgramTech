using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    //Интерфейс предназначен для задания базовой информации о накладаной на графическом интерфейсе. Поиск осуществляет кладовищик.
    public interface ISetInfoInvoiceForSearchInvoice
    {
        //Задание номера накладной
        void setNumberInvoice(string number);
        //Задание ФИО_заказчика/Название_организации
        void setName(string name);
        //Задание суммарной стоимости заказа
        void setCost(string cost);

    }
}
