using System;
using System.Windows.Forms;
using Presentation;

namespace View.ClientManager
{
    public partial class ClientManagerAddOrderView : Form, IClientManagerAddOrderView
    {
        private readonly ApplicationContext _context;
        public ClientManagerAddOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void radioBtn_Delivery_Clicked(object o, EventArgs e)
        {
            this.GroupBoxHomeAddress.Visible = true;
        }

        private void radioBtn_PickUp_Clicked(object o, EventArgs e)
        {
            this.GroupBoxHomeAddress.Visible = false;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

    }
}
