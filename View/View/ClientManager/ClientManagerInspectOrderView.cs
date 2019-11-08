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
    public partial class ClientManagerInspectOrderView : Form, IClientManagerInspectOrderView
    {
        private readonly ApplicationContext _context;

        public ClientManagerInspectOrderView(ApplicationContext context)
        {
            _context = context;
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        public event Action CancelOrder;
        public event Action EditOrder;
        public event Action Back;
        public event Action SearchOrder;

        private void btn_CancelOrder_Click(object o, EventArgs e) { CancelOrder?.Invoke(); }

        private void btn_EditOrder_Click(object o, EventArgs e) { EditOrder?.Invoke(); }

        private void btn_Back_Click(object o, EventArgs e) { Back?.Invoke(); }

        private void btn_SearchOrder_Click(object o, EventArgs e) { SearchOrder?.Invoke(); }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
