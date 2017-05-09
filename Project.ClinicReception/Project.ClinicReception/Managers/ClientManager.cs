using System;
using System.Windows.Forms;
using ClinicReception.UserInterface.UserControls;
using Project.ClinicReception.Forms;
using Project.ClinicReception.Helpers;

namespace Project.ClinicReception.Managers
{
    public class ClientManager : IEditable
    {
        public ClientManager()
        {
        }

        public void Delete(CallbackRefresh refresh, Guid id, IFillable control)
        {
            ServiceHelper.Client.DeleteClient(id);
        }

        public void Edit(CallbackRefresh refresh,Guid id, IFillable control)
        {
            EditClientForm editClient = new EditClientForm(id);
            editClient.ShowInTaskbar = false;

            if (editClient.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }     
        }

        public void Add(CallbackRefresh refresh, IFillable control)
        {
            ClientForm addClient = new ClientForm();
            addClient.ShowInTaskbar = false;
            if (addClient.ShowDialog() == DialogResult.OK)
            {
                refresh.Invoke(control);
            }
        }
    }
}