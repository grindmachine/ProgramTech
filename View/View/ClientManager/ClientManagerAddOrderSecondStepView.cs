using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class ClientManagerAddOrderSecondStepView : Form, IClientManagerAddOrderSecondStepView
    {
        private readonly ApplicationContext _context;
        public ClientManagerAddOrderSecondStepView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public event Action AddProduct;
        public event Action Cancel;
        public event Action Back;

        private void btn_Back_Click(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void btn_Cancel_Click(object o, EventArgs e)
        {
            Cancel?.Invoke();
        }

        private void btn_AddProduct_Click(object o, EventArgs e)
        {
            AddProduct?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

    }
}
