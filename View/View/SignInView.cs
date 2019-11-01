using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class SignInView : Form, ISignInView
    {

        private readonly ApplicationContext _context;

        public event Action OpenClientManager;
        public event Action OpenBooker;
        public event Action OpentStorekeeper;
        public event Action OpenPurcрManager;
        public event Action OpenCourier;

        public SignInView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_bookerButton_Click(object sender, EventArgs e)
        {
            OpenBooker?.Invoke();
        }

        private void btn_storekeeperButton_Click(object sender, EventArgs e)
        {
            OpentStorekeeper?.Invoke();
        }

        private void btn_PurcрManagerButton_Click(object sender, EventArgs e)
        {
            OpenPurcрManager?.Invoke();
        }

        private void btn_ClientManagerButton_Click(object sender, EventArgs e)
        {
            OpenClientManager?.Invoke();
        }

        private void btn_CourierButton_Click(object sender, EventArgs e)
        {
            OpenCourier?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
