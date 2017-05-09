using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            var item = new AccountEntity
            {
                Id = Guid.NewGuid(),
                Login = tbLogin.Text,
                Password = tbPassword.Text
            };
            ServiceHelper.Client.AddAccount(item);
            DialogResult = DialogResult.OK;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
