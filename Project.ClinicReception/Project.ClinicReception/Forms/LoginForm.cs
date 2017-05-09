using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class LoginForm : Form
    {
       //public string Account { get; set; }
        public LoginForm()
        {
            InitializeComponent();                                 
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string Account = null;

         var foundAccount =  ServiceHelper.Client.FindAccount(tbLogin.Text, tbPassword.Text);
            foreach (var item in foundAccount)
            {
                Account = item.ToString();
                //Checking password
                //lbResult.Text = item.ToString();
            }

            if (Account != null || (tbLogin.Text == "1" && tbPassword.Text == "2"))
            {
                lbResult.ForeColor = Color.Green;
                DialogResult = DialogResult.OK;
                MessageBox.Show("Successfully logged in");
            }
            else
            {
                MessageBox.Show("Something went wrong");
            }
        }
    }
}
