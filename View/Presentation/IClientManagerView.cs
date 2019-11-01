using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface IClientManagerView : IView
    {
        event Action addOrder;
        event Action lookOrder;
    }
}
