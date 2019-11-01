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
    public partial class ClientManagerView : Form, IClientManagerView
    {
        private readonly ApplicationContext _context;
        public ClientManagerView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public event Action addOrder;
        public event Action lookOrder;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void btn_AddOrder_click(object sender, EventArgs e)
        {
            addOrder?.Invoke();
        }

        private void btn_LookOrder_click(object sender, EventArgs e)
        {
            lookOrder?.Invoke();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
