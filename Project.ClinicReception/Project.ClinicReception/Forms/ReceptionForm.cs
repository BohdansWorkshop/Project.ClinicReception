
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ClinicReception.UserInterface.UserControls;
using Project.ClinicReception.Forms;
using Project.ClinicReception.Forms.UserControls;
using Project.ClinicReception.Helpers;
using Project.ClinicReception.Managers;

namespace Project.ClinicReception
{
    public partial class ReceptionForm : Form
    {
        private UcShowAllElements _showAllClients;
        private UcShowAllElements _showAllDoctors;
        private UcShowAllElements _showAllOrders;
        public ReceptionForm()
        {
            InitializeComponent();
            tabControl_SelectedIndexChanged(tabControl, null);
        }

        private void ReceptionForm_Load(object sender, System.EventArgs e)
        {
            LoginForm login = new LoginForm();
            if (login.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
        }

        private void tabControl_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (tabControl.SelectedTab.Name == tabClients.Name)
            {
                var clientManager = new ClientManager();                         
                _showAllClients = new UcShowAllElements(clientManager, LoadClients);                          
                tabClients.Controls.Add(_showAllClients);          
            }
            if (tabControl.SelectedTab.Name == tabDoctors.Name)
            {
                var doctorManager = new DoctorManager();
                _showAllDoctors = new UcShowAllElements(doctorManager, LoadDoctors);
                tabDoctors.Controls.Add(_showAllDoctors);
            }
            if (tabControl.SelectedTab.Name == tabOrders.Name)
            {
                var orderManager = new OrderManager();
                _showAllOrders = new UcShowAllElements(orderManager, LoadOrders);
                tabOrders.Controls.Add(_showAllOrders);
            }
        }

        private void LoadDoctors(IFillable currentControl)
        {
            var doctors = ServiceHelper.Client.GetDoctors();
            Dictionary<string, int> columns = new Dictionary<string, int>
            {
                {"Id", 1},
                {"Name", 100},
                {"Sex", 50},
                {"Age", 40},
                {"Qualification", 100},
                {"Phone", 120},
                {"Graphic", 90},
                {"Date", 120},
                {"Edited", 120}
            };
            var items = doctors?.Select(x => new[]
        { x.Id.ToString(),
              x.Name,
              x.Sex.ToString(),
              x.Age.ToString(),
              x.Qualification.ToString(),
              x.Phone.ToString(),
              x.Graphic.ToString(),
              x.CreateDate.ToString(),
              x.EditedDate.ToString() }).ToArray();
            currentControl.FillControl(columns, items);
        }
        private void LoadClients(IFillable currentControl)
        {
            var clients = ServiceHelper.Client.GetClients();
            Dictionary<string, int> columns = new Dictionary<string, int>
            {
                {"Id", 1},
                {"Name", 100},
                {"Sex", 50},
                {"Age", 40},
                {"Phone", 120},
                {"Date", 120 },
                {"Edited", 120 }
            };
            var items = clients?.Select(x => new[] 
            { x.Id.ToString(),
              x.Name,
              x.Sex.ToString(),
              x.Age.ToString(),
              x.Phone.ToString(),
              x.CreateDate.ToString(),
              x.EditedDate.ToString() }).ToArray();
            currentControl.FillControl(columns, items);
        }

        private void LoadOrders(IFillable currentControl)
        {
            var orders = ServiceHelper.Client.GetOrders();
            Dictionary<string, int> columns = new Dictionary<string, int>
            {
                {"Id", 1},
                {"Client", 100},
                {"Doctor", 100},
                {"Time", 80},
                {"Cabinet", 50},
                {"Price", 50},
                {"Date", 120},
                {"Edited", 120}
            };
            var items = orders?.Select(x => new[]
            {
                x.Id.ToString(),
                x.ClientOrder.ToString(),
                x.DoctorOrder.ToString(),
                x.Time,
                x.Cabinet.ToString(),
                x.Price.ToString(),
                x.CreateDate.ToString(),
                x.EditedDate.ToString()
            }).ToArray();
            currentControl.FillControl(columns, items);
        }
        private void addToolStripMenuItem1_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            AboutBox a = new AboutBox();
            a.Show();
        }

        private void createNewAccountToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            if (regForm.ShowDialog() == DialogResult.Cancel)
            {
                Close();
            }
        }
    }
}
