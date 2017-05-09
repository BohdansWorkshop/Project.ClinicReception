using System;
using System.Windows.Forms;
using ClinicReception.UserInterface.UserControls;
using Project.ClinicReception.Forms;
using Project.ClinicReception.Helpers;

namespace Project.ClinicReception.Managers
{
    public class DoctorManager : IEditable
    {
        public DoctorManager()
        {

        }

        public void Delete(CallbackRefresh refresh, Guid id, IFillable control)
        {
            ServiceHelper.Client.DeleteDoctor(id);
        }

        public void Edit(CallbackRefresh refresh, Guid id, IFillable control)
        {
            EditDoctorForm editDoctor = new EditDoctorForm(id);
            editDoctor.ShowInTaskbar = false;

            if (editDoctor.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }

        public void Add(CallbackRefresh refresh, IFillable control)
        {
            DoctorForm addDoctor = new DoctorForm();
            addDoctor.ShowInTaskbar = false;
            if (addDoctor.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}