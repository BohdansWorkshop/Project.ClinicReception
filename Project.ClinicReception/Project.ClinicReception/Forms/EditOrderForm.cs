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
            ClientModel clientModel = (ClientModel)cbClient.SelectedItem;
            DoctorModel doctorModel = (DoctorModel)cbDoctor.SelectedItem;

            Client client = new Client()
            {
                Age = clientModel.Age,
                Id = Guid.NewGuid(),
                CreateDate = clientModel.CreateDate,
                EditedDate = clientModel.EditedDate,
                Phone = clientModel.Phone,
                Name = clientModel.Name,
                Sex = clientModel.Sex,

            };
            Doctor doctor = new Doctor()
            {
                Id = Guid.NewGuid(),
                Age = doctorModel.Age,
                CreateDate = doctorModel.CreateDate,
                EditedDate = doctorModel.EditedDate,
                Graphic = doctorModel.Graphic,
                Name = doctorModel.Name,
                Phone = doctorModel.Phone,
                Sex = doctorModel.Sex,
                Qualification = doctorModel.Qualification,
            };
            var order = new OrderModel
            {
                Id = _orderId,
                ClientOrder = (ClientModel)cbClient.SelectedItem,
                DoctorOrder = (DoctorModel)cbDoctor.SelectedItem,
                Time = tbTime.Text,
                Cabinet = tbCabinet.Text,
                Price =(double) nudPrice.Value,
                CreateDate = dtpCreatedDate.Value,
                EditedDate = dtpEditedDate.Value,
            };

            ServiceHelper.Client.EditOrder(order);
        }
    }
}
