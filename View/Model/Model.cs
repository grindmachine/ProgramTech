using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Model : IModel
    {
        public IBriefInvoiceInfo findIncomingInvoice(int number)
        {
            BriefInvoiceInfo info = new BriefInvoiceInfo("Павел", "1234", "50 рублей");
            return info;
        }
    }
}
