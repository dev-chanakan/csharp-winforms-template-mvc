﻿using Liberty.Infrastructure.Domain;
using Liberty.Infrastructure.UnitOfWork;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Repository.NHibernate.Repositories
{
    public abstract class Repository<T, TId> : IRepository<T, TId>
        where T : class
    {
        protected Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        private readonly IUnitOfWork _unitOfWork;

        public virtual IEnumerable<T> FindAll()
        {
            return Session.Query<T>().ToList();
        }

        public virtual T FindById(TId id)
        {
            return Session.Get<T>(id);
        }

        public virtual void Create(T entity)
        {
            UnitOfWork.RegisterCreate(entity);
        }

        public virtual void Modify(T entity)
        {
            UnitOfWork.RegisterModify(entity);
        }

        public virtual void Delete(T entity)
        {
            UnitOfWork.RegisterDelete(entity);
        }

        protected ISession Session
        {
            get { return SessionFactory.GetCurrentSession(); }
        }

        protected IUnitOfWork UnitOfWork
        {
            get { return _unitOfWork; }
        }
    }
}
