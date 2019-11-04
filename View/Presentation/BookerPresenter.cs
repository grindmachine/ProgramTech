using Ninject;

namespace Presentation
{
    internal class BookerPresenter : IPresenter
    {
        private readonly IKernel _kernel;
        private readonly IBookerView _view;

        public BookerPresenter(IKernel kernel, IBookerView view)
        {
            _kernel = kernel;
            _view = view;
        }


        public void Run()
        {
            _view.Show();
        }
    }
}
