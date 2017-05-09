using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Project.ClinicReception.DbEntity;
using Project.ClinicReception.Service.DTO;

namespace Project.ClinicReception.Service
{
    [ServiceContract]
    public interface IReceptionService
    {
    
        [OperationContract]
        List<ClientModel> GetClients();
        [OperationContract]
        List<DoctorModel> GetDoctors();
        [OperationContract]
        List<OrderModel> GetOrders();
        [OperationContract]
        Client GetDetailClientInfo(Guid clientId);
        [OperationContract]
        Doctor GetDetailDoctorInfo(Guid doctorId);
        [OperationContract]
        Order GetDetailOrderInfo(Guid orderId);
        [OperationContract]
        void AddClient(ClientModel newClient);
        [OperationContract]
        void EditClient(ClientModel client);
        [OperationContract]
        void DeleteClient(Guid clientId);
        [OperationContract]
        void AddDoctor(DoctorModel newDoctor);
        [OperationContract]
        void DeleteDoctor(Guid doctorId);
        [OperationContract]
        void EditDoctor(DoctorModel doctor);
        [OperationContract]
        void AddOrder(OrderModel order);
        [OperationContract]
        void DeleteOrder(Guid orderId);
        [OperationContract]
        void EditOrder(OrderModel order);
        [OperationContract]
        void AddAccount(AccountEntity item);
        [OperationContract]
        IQueryable<AccountEntity> FindAccount(string login, string password);

    }
}
