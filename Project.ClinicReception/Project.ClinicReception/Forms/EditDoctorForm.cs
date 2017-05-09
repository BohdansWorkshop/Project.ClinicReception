using System;
using System.Linq;
using System.Windows.Forms;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class EditDoctorForm : Form
    {
        public EditDoctorForm()
        {
            InitializeComponent();
        }

        private readonly Guid _doctorId;

        public EditDoctorForm(Guid id)
        {
            _doctorId = id;
            InitializeComponent();
            cbSex.Items.AddRange(Enum.GetValues(typeof(Sex)).Cast<object>().ToArray());
            cbSex.SelectedIndex = 0;
            cbQualification.Items.AddRange(Enum.GetValues(typeof(DoctorQualification)).Cast<object>().ToArray());
            cbQualification.SelectedIndex = 0;
            dtpCreatedDate.Enabled = false;
            FillForm();
        }
        private void FillForm()
        {
            var doctor = ServiceHelper.Client.GetDetailDoctorInfo(_doctorId);
            tbName.Text = doctor.Name;
            tbPhone.Text = doctor.Phone;
            nudAge.Value = doctor.Age;
            cbQualification.SelectedItem = doctor.Qualification;
            cbSex.SelectedItem = doctor.Sex;
            dtpEditedDate.Value = DateTime.Now;
            dtpCreatedDate.Value = doctor.CreateDate;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var doctor = new DoctorModel
            {
                Id = _doctorId,
                Name = tbName.Text.Trim(),
                Phone = tbPhone.Text.Trim(),
                Qualification = (DoctorQualification)cbQualification.SelectedIndex,
                Age = (int)nudAge.Value,
                Sex = (Sex)cbSex.SelectedItem,
                CreateDate = dtpCreatedDate.Value,
                EditedDate = dtpCreatedDate.Value,
            };
            if (rbGraphic1.Checked)
                doctor.Graphic = rbGraphic1.Text;
            else if (rbGraphic2.Checked)
            {
                doctor.Graphic = rbGraphic2.Text;
            }

            ServiceHelper.Client.EditDoctor(doctor);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
