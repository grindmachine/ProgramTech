using System;

namespace Presentation
{
    internal interface IClientManagerAddOrderView : IView, IBack
    {
        event Action NextStep;

        string getName();
        void setName(string name);
        string getSurname();
        void setSurname(string surname);
        string getPatronymic();
        void setPatronymic(string patronymic);
        string getCity();
        void setCity(string city);
        string getStreet();
        void setStreet(string street);
        string getPavilion();
        void setPavilion(string pavilion);
        string getHouseNumber();
        void setHouseNumber(string houseNumber);
        string getFlat();
        void setFlat(string flat);
        string getPhoneNumber();
        void setPhoneNumber(string phoneNumber);
        string getEmailAddress();
        void setEmailAddress(string emailAddress);
    }
}
