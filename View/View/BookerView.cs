using Presentation;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class BookerView : Form, IBookerView
    {
        private readonly ApplicationContext _context;
        public BookerView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public event Action CheckClientPayment;
        public event Action PayOrderProvider;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
