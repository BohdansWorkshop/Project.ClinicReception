using System;
using System.Collections.Generic;
using System.Linq;
using Project.ClinicReception.DataAccess;
using Project.ClinicReception.DataAccess.Repositories;
using Project.ClinicReception.DbEntity;
using Project.ClinicReception.Logic;
using Project.ClinicReception.Service.DTO;

namespace Project.ClinicReception.Service
{
    public class ReceptionService : IReceptionService
    {
        private ClientBusinessLogic _clientLogic;
        private DoctorBusinessLogic _doctorLogic;
        private OrderBusinessLogic _orderLogic;
        private AccountBusinessLogic _accLogic;

        public ReceptionService()
        {
            ReceptionContext _context = new ReceptionContext();
            _orderLogic = new OrderBusinessLogic(new OrderRepository(_context));
            _clientLogic = new ClientBusinessLogic(new ClientRepository(_context));
            _doctorLogic = new DoctorBusinessLogic(new DoctorRepository(_context));
            _accLogic = new AccountBusinessLogic(new AccountRepository(_context));
        }
        public List<ClientModel> GetClients()
        {
            return _clientLogic.GetClients().Select(x => new ClientModel
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                Sex = x.Sex,
                Phone = x.Phone.ToString(),
                CreateDate = x.CreateDate,
                EditedDate = x.EditedDate,
            }).ToList();
        }
        public List<DoctorModel> GetDoctors()
        {
            return _doctorLogic.GetDoctors().Select(x => new DoctorModel
            {
                Id = x.Id,
                Name = x.Name,
                Age = x.Age,
                Sex = x.Sex,
                Qualification = x.Qualification,
                Phone = x.Phone,
                Graphic = x.Graphic,
                CreateDate = x.CreateDate,
                EditedDate = x.EditedDate,
            }).ToList();
        }

        public List<OrderModel> GetOrders()
        {
            return _orderLogic.GetOrderss().Select(x => new OrderModel
            {
                Id = x.Id,
                ClientOrder = new ClientModel()
                {
                    Id = x.ClientOrder.Id,
                    Name = x.ClientOrder.Name,
                    Age = x.ClientOrder.Age,
                    CreateDate = x.ClientOrder.CreateDate,
                    EditedDate = x.ClientOrder.EditedDate,
                    Phone = x.ClientOrder.Phone,
                    Sex = x.ClientOrder.Sex,
                },
                DoctorOrder = new DoctorModel()
                {
                    Age = x.DoctorOrder.Age,
                    Id = x.DoctorOrder.Id,
                    CreateDate = x.DoctorOrder.CreateDate,
                    EditedDate = x.DoctorOrder.EditedDate,
                    Graphic = x.DoctorOrder.Graphic,
                    Name = x.DoctorOrder.Name,
                    Sex = x.DoctorOrder.Sex,
                    Phone = x.DoctorOrder.Phone,
                    Qualification = x.DoctorOrder.Qualification,
                },
                Time = x.Time.ToString(),
                Cabinet = x.Cabinet,
                Price = x.Price,
                CreateDate = x.CreateDate,
                EditedDate = x.EditedDate
            }).ToList();
        }
        public Client GetDetailClientInfo(Guid clientId)
        {
            return _clientLogic.GetById(clientId);
        }
        public Doctor GetDetailDoctorInfo(Guid doctorId)
        {
            return _doctorLogic.GetById(doctorId);
        }

        public Order GetDetailOrderInfo(Guid orderId)
        {
            return _orderLogic.GetById(orderId);
        }
        public void AddClient(ClientModel clientmodel)
        {
            var client = new Client()
            {
                Id = clientmodel.Id,
                EditedDate = clientmodel.EditedDate,
                CreateDate = clientmodel.CreateDate,
                Age = clientmodel.Age,
                Name = clientmodel.Name,
                Phone = clientmodel.Phone,
                Sex = clientmodel.Sex,
            };
            _clientLogic.Add(client);
        }
        public void EditClient(ClientModel clientmodel)
        {
            var client = new Client()
            {
                Id = clientmodel.Id,
                EditedDate = clientmodel.EditedDate,
                CreateDate = clientmodel.CreateDate,
                Age = clientmodel.Age,
                Name = clientmodel.Name,
                Phone = clientmodel.Phone,
                Sex = clientmodel.Sex,
            }; ;
            _clientLogic.Update(client);
        }
        public void DeleteClient(Guid clientId)
        {
            _clientLogic.DeleteClient(clientId);
        }
        public void AddDoctor(DoctorModel doctormodel)
        {
            var doctor = new Doctor()
            {
                Id = doctormodel.Id,
                Name = doctormodel.Name,
                Age = doctormodel.Age,
                Phone = doctormodel.Phone,
                Sex = doctormodel.Sex,
                Graphic = doctormodel.Graphic,
                Qualification = doctormodel.Qualification,
                CreateDate = doctormodel.CreateDate,
                EditedDate = doctormodel.EditedDate,
            };
            _doctorLogic.Add(doctor);
        }
        public void EditDoctor(DoctorModel doctormodel)
        {
            var doctor = new Doctor()
            {
                Id = doctormodel.Id,
                Name = doctormodel.Name,
                Age = doctormodel.Age,
                Phone = doctormodel.Phone,
                Sex = doctormodel.Sex,
                Graphic = doctormodel.Graphic,
                Qualification = doctormodel.Qualification,
                CreateDate = doctormodel.CreateDate,
                EditedDate = doctormodel.EditedDate,
            };
            _doctorLogic.EditDoctor(doctor);
        }
        public void DeleteDoctor(Guid doctorId)
        {
            _doctorLogic.DeleteDoctor(doctorId);
        }
        public void AddOrder(OrderModel ordermodel)
        {
            Order order = new Order()
            {
                Cabinet = ordermodel.Cabinet,
                Price = ordermodel.Price,
                Time = ordermodel.Time,
                Id = ordermodel.Id,
                DoctorOrder = _doctorLogic.GetById(ordermodel.DoctorOrder.Id),
                ClientOrder = _clientLogic.GetById(ordermodel.ClientOrder.Id),
                CreateDate = ordermodel.CreateDate,
                EditedDate = ordermodel.EditedDate,
            };
            _orderLogic.Update(order);
        }
        public void EditOrder(OrderModel ordermodel)
        {
            Order order = new Order()
            {
                Cabinet = ordermodel.Cabinet,
                Price = ordermodel.Price,
                Time = ordermodel.Time,
                Id = ordermodel.Id,
                DoctorOrder = _doctorLogic.GetById(ordermodel.DoctorOrder.Id),
                ClientOrder = _clientLogic.GetById(ordermodel.ClientOrder.Id),
                CreateDate = ordermodel.CreateDate,
                EditedDate = ordermodel.EditedDate,
            };
            _orderLogic.EditOrder(order);
        }
        public void AddAccount(AccountEntity item)
        {
            _accLogic.Add(item);
        }
        public IQueryable<AccountEntity> FindAccount(string login, string password)
        {
            return _accLogic.FindAccount(login, password);
        }
        public void DeleteOrder(Guid orderId)
        {
            _orderLogic.DeleteOrder(orderId);
        }
    }
}
