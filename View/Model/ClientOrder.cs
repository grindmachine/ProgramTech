using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ClientOrder : IClientOrder
    {
        private string name;
        private string surname;
        private string patronymic;
        private int orderNumber;
        private DateTime date;
        private string emailAddress;
        private string phoneNumber;
        private string city;
        private string street;
        private string pavilion;
        private string houseNumber;
        private string flat;

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public string EmailAddress { get => emailAddress; set => emailAddress = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string Pavilion { get => pavilion; set => pavilion = value; }
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public string Flat { get => flat; set => flat = value; }
        public DateTime GetDate() { return date; }
        public void SetDate(DateTime _date) { date = _date; }
    }
}
