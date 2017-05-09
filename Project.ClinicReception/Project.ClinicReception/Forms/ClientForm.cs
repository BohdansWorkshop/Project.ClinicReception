using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class ClientForm : Form
    {
        private readonly Guid _clientId;
        public ClientForm()
        {
            _clientId = Guid.NewGuid();
            InitializeComponent();
            cbSex.Items.AddRange(Enum.GetValues(typeof(Sex)).Cast<object>().ToArray());
            cbSex.SelectedIndex = 0;
            dtpCreateDate.Value = DateTime.Now;
        }
        
        private void btOk_Click(object sender, EventArgs e)
        {
            var client = new ClientModel
            {
                Id = _clientId,
                Name = tbName.Text.Trim(),
                Phone = tbPhone.Text.Trim(),
                Age = (int)nudAge.Value,
                Sex = (Sex)cbSex.SelectedItem,
                CreateDate = dtpCreateDate.Value,
                EditedDate = dtpCreateDate.Value,

            };
            ServiceHelper.Client.AddClient(client);
            this.DialogResult = DialogResult.OK;
            Close();
        }

     
    }
}
