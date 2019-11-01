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
    public partial class PurcpManagerView : Form, IPurcpManagerView
    {

        private readonly ApplicationContext _context;
        public PurcpManagerView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public event Action ViewInfoOrderProd;
        public event Action AddOrder;
        public event Action ViewInfoProvider;
        public event Action AddProvider;
        public event Action RemoveProvider;
        public event Action ViewInfoEndedProd;

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
