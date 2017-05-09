using System;
using System.Linq;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.DataAccess.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>
    {
        public DoctorRepository(ReceptionContext context) : base(context)
        {
        }
    }
}