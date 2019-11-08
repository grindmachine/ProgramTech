using System;

namespace Presentation
{
    internal interface IClientManagerAddOrderView : IView, IBack
    {
        event Action NextStep;

        public string getName();
        public void setName(string name);
        public string getSurname();
        public void setSurname(string surname);
        public string getPatronymic();
        public void setPatronymic(string patronymic);
        public string getCity();
        public void setCity(string city);
        public string getStreet();
        public void setStreet(string street);
        public string getPavilion();
        public void setPavilion(string pavilion);
        public string getHouseNumber();
        public void setHouseNumber(string houseNumber);
        public string getFlat();
        public void setFlat(string flat);
        public string getPhoneNumber();
        public void setPhoneNumber(string phoneNumber);
        public string getEmailAddress();
        public void setEmailAddress(string emailAddress);
    }
}
