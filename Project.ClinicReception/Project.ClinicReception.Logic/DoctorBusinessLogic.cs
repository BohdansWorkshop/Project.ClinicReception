using System;
using System.Linq;
using Project.ClinicReception.DataAccess.Repositories;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.Logic
{
    public class DoctorBusinessLogic : BaseBusinessLogic<Doctor, DoctorRepository>
    {
        public IQueryable<Doctor> GetDoctors()
        {
            return Repository.GetAll();
        }

        public void EditDoctor(Doctor doctor)
        {
            Repository.Update(doctor);
        }

        public void DeleteDoctor(Guid doctorId)
        {
            var order = Repository.GetById(doctorId);
            Repository.Delete(order);
        }

        public DoctorBusinessLogic(DoctorRepository repository) : base(repository)
        {
        }
    }
}