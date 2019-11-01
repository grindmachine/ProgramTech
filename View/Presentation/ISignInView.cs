using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation
{
    public interface ISignInView: IView
    {
        event Action OpenClientManager;
        event Action OpenBooker;
        event Action OpentStorekeeper;
        event Action OpenPurcрManager;
        event Action OpenCourier;
    }
}
