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
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public int OrderNumber { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Pavilion { get; set; }
        public string HouseNumber { get; set; }
        public string Flat { get; set; }
        public DateTime GetDate();
        public void SetDate(DateTime _date);
        //public void getStatus(); public void SetStatus();
        //public void getPurchaseList public void setPurchaseList();
        //public void addPurchase(Purchase p); public void deletePurchase(Purchase p)
    }
}
