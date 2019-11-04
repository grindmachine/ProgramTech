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

namespace View.Storekeeper
{
    public partial class StorekeeperSearchIncomingInvoiceView : Form, IStorekeeperSearchIncomingInvoiceView
    {
        ApplicationContext _context;
        public StorekeeperSearchIncomingInvoiceView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action Search;
        public event Action ShowInvoiceContent;
        public event Action ConfirmAdmission;

        private void btn_Search_Click(object o, EventArgs e)
        {
            Search?.Invoke();
            this.PanelFoundInvoice.Visible = true;
        }

        private void btn_ShowInvcCont_Click(object o, EventArgs e)
        {
            ShowInvoiceContent?.Invoke();
        }

        private void btn_ConfirmAdmission_Click(object o, EventArgs e)
        {
            ConfirmAdmission?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
