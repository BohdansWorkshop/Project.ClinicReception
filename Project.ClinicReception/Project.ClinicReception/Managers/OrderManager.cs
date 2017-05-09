using System;
using System.Windows.Forms;
using ClinicReception.UserInterface.UserControls;
using Project.ClinicReception.Forms;
using Project.ClinicReception.Helpers;

namespace Project.ClinicReception.Managers
{
    public class OrderManager : IEditable
    {
        public OrderManager()
        {

        }

        public void Delete(CallbackRefresh refresh, Guid id, IFillable control)
        {
            ServiceHelper.Client.DeleteOrder(id);
        }

        public void Edit(CallbackRefresh refresh, Guid id, IFillable control)
        {
            EditOrderForm editDoctor = new EditOrderForm(id);
            editDoctor.ShowInTaskbar = false;

            if (editDoctor.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }

        public void Add(CallbackRefresh refresh, IFillable control)
        {
            OrderForm addDoctor = new OrderForm();
            addDoctor.ShowInTaskbar = false;
            if (addDoctor.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}