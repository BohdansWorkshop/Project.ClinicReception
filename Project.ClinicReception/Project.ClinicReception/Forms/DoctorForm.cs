using System;
using System.Linq;
using System.Windows.Forms;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class DoctorForm : Form
    {
        private readonly Guid _doctorId;
        public DoctorForm()
        {
            _doctorId = Guid.NewGuid();
            InitializeComponent();
            cbSex.Items.AddRange(Enum.GetValues(typeof(Sex)).Cast<object>().ToArray());
            cbSex.SelectedIndex = 0;
            cbQualification.Items.AddRange(Enum.GetValues(typeof(DoctorQualification)).Cast<object>().ToArray());
            cbQualification.SelectedIndex = 0;
            dtpCreateDate.Value = DateTime.Now;
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
                CreateDate = dtpCreateDate.Value,
                EditedDate = dtpCreateDate.Value,
            };
            if (rbGraphic1.Checked)
                doctor.Graphic = rbGraphic1.Text;
            else if (rbGraphic2.Checked)
            {
                doctor.Graphic = rbGraphic2.Text;
            }
     
            ServiceHelper.Client.AddDoctor(doctor);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
