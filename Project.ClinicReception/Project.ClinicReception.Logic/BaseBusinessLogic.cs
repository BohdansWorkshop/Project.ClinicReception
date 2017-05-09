using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Project.ClinicReception.DataAccess;
using Project.ClinicReception.DataAccess.Repositories;
using Project.ClinicReception.DbEntity;

namespace Project.ClinicReception.Logic
{
    public class BaseBusinessLogic<TEntity, TRepository>
             where TEntity : IdEntity
             where TRepository : BaseRepository<TEntity>
    {
        protected readonly TRepository Repository;

        public BaseBusinessLogic(TRepository repository)
        {
            Repository = repository;
        }

        public IQueryable<TEntity> GetAll()
        {
            return Repository.GetAll();
        }


        public TEntity GetById(Guid id)
        {
            return Repository.GetById(id);
        }

        public void Add(TEntity item)
        {
            Repository.Add(item);
        }

        public void Update(TEntity item)
        {
            Repository.Update(item);
        }

    }
}
