using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class BriefInvoiceInfo : IBriefInvoiceInfo
    {
        private string Name;
        private string Number;
        private string Cost;

        public BriefInvoiceInfo() { }
        public BriefInvoiceInfo(string name, string number, string cost)
        {
            setName(name);
            setNumber(number);
            setCost(cost);
        }

        public string getCost()
        {
            return Cost;
        }

        public string getName()
        {
            return Name;
        }

        public string getNumber()
        {
            return Number;
        }

        public void setCost(string cost)
        {

            Cost = string.Copy(cost);
        }

        public void setName(string name)
        {
            Name = string.Copy(name);
        }

        public void setNumber(string number)
        {
            Number = string.Copy(number);
        }
    }
}
