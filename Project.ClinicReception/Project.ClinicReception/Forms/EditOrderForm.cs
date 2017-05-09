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
    public partial class EditOrderForm : Form
    {
        private readonly Guid _orderId;
        public EditOrderForm(Guid id)
        {           
            InitializeComponent();
            _orderId = id;
            dtpCreatedDate.Enabled = false;
            FillForm();
        
        }
        public EditOrderForm()
        {
            InitializeComponent();
        }

        private void FillForm()
        {          
            var order = ServiceHelper.Client.GetDetailOrderInfo(_orderId);
            cbClient.SelectedItem = order.ClientOrder.ToString();
            cbDoctor.SelectedItem = order.DoctorOrder.ToString();
            tbTime.Text = order.Time;
            tbCabinet.Text = order.Cabinet;
            nudPrice.Text = order.Price.ToString();
            dtpEditedDate.Value = DateTime.Now;
            dtpCreatedDate.Value = order.CreateDate;
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            var order = new OrderModel
            {
                Id = _orderId,
                Time = tbTime.Text,
                ClientOrder = (ClientModel)cbClient.SelectedItem,
                DoctorOrder = (DoctorModel)cbDoctor.SelectedItem,
                Cabinet = tbCabinet.Text.Trim(),
                Price = (double)nudPrice.Value,
                CreateDate = dtpCreatedDate.Value,
                EditedDate = dtpEditedDate.Value,
            };
            ServiceHelper.Client.EditOrder(order);
        }
    }
}
