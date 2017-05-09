using System;
using System.Linq;
using System.Windows.Forms;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class EditClientForm : Form
    {
        private readonly Guid _clientId;

        public EditClientForm(Guid id)
        {
            _clientId = id;
            InitializeComponent();
            cbSex.Items.AddRange(Enum.GetValues(typeof(Sex)).Cast<object>().ToArray());
            cbSex.SelectedIndex = 0;
            dtpCreatedDate.Enabled = false;
            FillForm();
        }
        private void FillForm()
        {
            var client = ServiceHelper.Client.GetDetailClientInfo(_clientId);
            tbName.Text = client.Name;
            tbPhone.Text = client.Phone;
            nudAge.Value = client.Age;
            cbSex.SelectedItem = client.Sex;
            dtpEditedDate.Value = DateTime.Now;
            dtpCreatedDate.Value = client.CreateDate;
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
                CreateDate = dtpCreatedDate.Value,
                EditedDate = dtpEditedDate.Value,
            };
            ServiceHelper.Client.EditClient(client);
            this.DialogResult = DialogResult.OK;
            Close();
        }

    }
}
