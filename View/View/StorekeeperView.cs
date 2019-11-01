using Presentation;
using System;
using System.Windows.Forms;

namespace View
{
    public partial class StorekeeperView : Form, IStorekeeperView
    {
        private readonly ApplicationContext _context;
        public StorekeeperView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public event Action SearchPurchInvoice;
        public event Action SearchExprenseInvoice;
        public event Action ShowListClientPurch;
        public event Action ShowListCourierPurch;

        private void btn_SearchPurchInvoiceButton_Click(object o, EventArgs e)
        {
            SearchPurchInvoice?.Invoke();
        }

        private void btn_SearchExprenseInvoiceButton_Click(object o, EventArgs e)
        {
            SearchExprenseInvoice?.Invoke();
        }

        private void btn_ShowListClientPurchButton_Click(object o, EventArgs e)
        {
            ShowListClientPurch?.Invoke();
        }

        private void btn_ShowListCourierPurchButton_Click(object o, EventArgs e)
        {
            ShowListCourierPurch?.Invoke();
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
