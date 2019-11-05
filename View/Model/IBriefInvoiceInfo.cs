using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //Интерфейс, который предназначен для получения краткой информации о накладной, чтобы отобразить ее в окне
    //поиск накладной(StorekeeperSearchInvoiceView)
    public interface IBriefInvoiceInfo
    {
        //Номер накладной
        void setNumber(string number);
        string getNumber();
        //Имя заказчика/Название организации поставщика
        void setName(string name);
        string getName();
        //Стоимость
        void setCost(string cost);
        string getCost();

    }
}
