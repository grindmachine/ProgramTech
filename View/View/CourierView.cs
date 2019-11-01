using Presentation;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class CourierView : Form, ICourierView
    {
        private readonly ApplicationContext _context;
        public CourierView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public event Action GetInfoOrder; 

        private void btn_GetInfoOrderButton_Click(object o, EventArgs e)
        {
            GetInfoOrder?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
