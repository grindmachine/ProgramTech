using System;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using Presentation;

namespace View
{
    public partial class ClientManagerAddOrderView : Form, IClientManagerAddOrderView
    {
        private readonly ApplicationContext _context;

        public event Action Back;
        public event Action NextStep;

        public ClientManagerAddOrderView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void radioBtn_Delivery_Clicked(object o, EventArgs e)
        {
            this.GroupBoxHomeAddress.Visible = true;
        }

        private void radioBtn_PickUp_Clicked(object o, EventArgs e)
        {
            this.GroupBoxHomeAddress.Visible = false;
        }

        private void btn_Back_Click(object o, EventArgs e)
        {
            Back?.Invoke();
        }

        private void btn_NextStepClick(object o, EventArgs e)
        {
            if (checkRequiredFields())
                NextStep?.Invoke();
            else
                this.LabelMessageRequiredFields.Visible = true;
        }

        private bool checkRequiredFields()
        {
            if (TextBoxName.Text.Length == 0) return false;
            if (TextBoxSurname.Text.Length == 0) return false;
            if (TextBoxPatronymic.Text.Length == 0) return false;
            if (TextBoxPhoneNumber.Text.LastIndexOfAny(("0123456789".ToCharArray())) == -1) return false;
            if (RadiobuttonDelivery.Checked)
            {
                if (TextBoxCity.Text.Length == 0) return false;
                if (TextBoxStreet.Text.Length == 0) return false;
                if (TextBoxHouseNumber.Text.Length == 0) return false;
                if (TextBoxPavilion.Text.Length == 0) return false;
                if (TextBoxFlat.Text.Length == 0) return false;
            }
            return true;
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }


        public string getName() => this.TextBoxName.Text;
        public void setName(string name) => this.TextBoxName.Text = String.Copy(name);
        public string getSurname() => this.TextBoxSurname.Text;
        public void setSurname(string surname) => this.TextBoxSurname.Text = String.Copy(surname);
        public string getPatronymic() => this.TextBoxPatronymic.Text;
        public void setPatronymic(string patronymic) => this.TextBoxPatronymic.Text = String.Copy(patronymic);
        public string getCity() => this.TextBoxCity.Text;
        public void setCity(string city) => this.TextBoxCity.Text = String.Copy(city);
        public string getStreet() => this.TextBoxStreet.Text;
        public void setStreet(string street) => this.TextBoxStreet.Text = String.Copy(street);
        public string getPavilion() => this.TextBoxPavilion.Text;
        public void setPavilion(string pavilion) => this.TextBoxPavilion.Text = String.Copy(pavilion);
        public string getHouseNumber() => this.TextBoxHouseNumber.Text;
        public void setHouseNumber(string houseNumber) => this.TextBoxHouseNumber.Text = String.Copy(houseNumber);
        public string getFlat() => this.TextBoxFlat.Text;
        public void setFlat(string flat) => this.TextBoxFlat.Text = String.Copy(flat);
        public string getPhoneNumber() => this.TextBoxPhoneNumber.Text;
        public void setPhoneNumber(string phoneNumber) => this.TextBoxPhoneNumber.Text = String.Copy(phoneNumber);
        public string getEmailAddress() => this.TextBoxEmailAddress.Text;
        public void setEmailAddress(string emailAddress) => this.TextBoxEmailAddress.Text = String.Copy(emailAddress);

    }
}
