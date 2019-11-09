using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public interface IClientOrder
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Patronymic { get; set; }
        int OrderNumber { get; set; }
        string EmailAddress { get; set; }
        string PhoneNumber { get; set; }
        string City { get; set; }
        string Street { get; set; }
        string Pavilion { get; set; }
        string HouseNumber { get; set; }
        string Flat { get; set; }
        DateTime GetDate();
        void SetDate(DateTime _date);
        //public void getStatus(); public void SetStatus();
        //public void getPurchaseList public void setPurchaseList();
        //public void addPurchase(Purchase p); public void deletePurchase(Purchase p)
    }
}
