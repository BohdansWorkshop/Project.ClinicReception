using System;
using System.Data.Entity.Migrations;
using System.Linq;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.DataAccess.Repositories
{
    public class BaseRepository<T> where T : IdEntity
    {
        protected readonly ReceptionContext Context;

        public BaseRepository(ReceptionContext context)
        {
            Context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public void Add(T entity)
        {
            Context.Set<T>().Add(entity);
            Context.SaveChanges();
        }
        public void Update(T entity)
        {
            Context.Set<T>().AddOrUpdate(entity);
            Context.SaveChanges();
        }

        public void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
        }

        public virtual T GetById(Guid id)
        {
            return Context.Set<T>().Find(id);
        }

        public virtual IQueryable<AccountEntity> FindByLoginAndPass(string login, string password)
        {
            var logins = from b in Context.Accounts
                where (b.Login == login && b.Password == password)
                select b;

            return logins;
        }
    }
}