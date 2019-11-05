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
    public partial class StorekeeperSearchSalesInvoiceView : Form, IBack, IStorekeeperSearchSalesInvoiceView
    {
        private readonly ApplicationContext _context;
        public StorekeeperSearchSalesInvoiceView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public event Action Back;
        public event Search search;
        public event Action ShowInvoiceContent;
        public event Action ConfirmAdmission;

        private void btn_Search_Click(object o, EventArgs e)
        {
            this.PanelNotFoundInvoice.Visible = false;
            this.PanelFoundInvoice.Visible = false;
            this.LabelNameOrganizSet.Text = " ";
            this.LabelNumberSet.Text = " ";
            this.LabelCostSet.Text = " ";
            if (search != null && search.Invoke())
                this.PanelFoundInvoice.Visible = true;
            else
                this.PanelNotFoundInvoice.Visible = true;
        }

        private void btn_ShowInvcCont_Click(object o, EventArgs e)
        {
            ShowInvoiceContent?.Invoke();
        }

        private void btn_IssuanceAdmission_Click(object o, EventArgs e)
        {
            ConfirmAdmission?.Invoke();
        }

        private void btn_Back_Click(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        public string getNumberInvoice()
        {
            return TextBoxNumberInvoice.Text;
        }

        public void setCost(string cost)
        {
            this.LabelCostSet.Text = cost;
        }

        public void setName(string name)
        {
            this.LabelNameOrganizSet.Text = name;
        }

        public void setNumberInvoice(string number)
        {
            this.LabelNumberSet.Text = number;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
