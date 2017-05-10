using System;
using System.Linq;
using System.Windows.Forms;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.ReceptionReference;

namespace Project.ClinicReception.Forms
{
    public partial class OrderForm : Form
    {
        private readonly Guid _orderId;
        public OrderForm()
        {
            InitializeComponent();
            nudPrice.Minimum = 0;
            nudPrice.Maximum = 10000;
            _orderId = Guid.NewGuid();
            cbClient.Items.AddRange(ServiceHelper.Client.GetClients().Cast<object>().ToArray());
            cbClient.SelectedIndex = 0;
            cbDoctor.Items.AddRange(ServiceHelper.Client.GetDoctors().Cast<object>().ToArray());
            cbDoctor.SelectedIndex = 0;
            dtpCreateDate.Value = DateTime.Now;
        }
        private void btOk_Click(object sender, EventArgs e)
        {        
            var order = new OrderModel
            {
                Id = _orderId,
                Time = tbTime.Text,
                ClientOrder =(ClientModel) cbClient.SelectedItem,
                DoctorOrder =(DoctorModel) cbDoctor.SelectedItem,
                Cabinet = tbCabinet.Text.Trim(),
                Price = (double)nudPrice.Value,
                CreateDate = dtpCreateDate.Value,
                EditedDate = dtpCreateDate.Value,
            };
            ServiceHelper.Client.AddOrder(order);
        } 
    }
}
