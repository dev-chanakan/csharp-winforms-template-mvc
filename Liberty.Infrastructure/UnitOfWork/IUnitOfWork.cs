using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Liberty.Infrastructure.UnitOfWork
{
	public interface IUnitOfWork
	{
        /// <summary>
        /// NHibernate
        /// </summary>
        /// <param name="entity"></param>      
        void RegisterModify(object entity);
        void RegisterCreate(object entity);
        void RegisterDelete(object entity);
        void Commit();
        ITransaction BeginTransaction();
        void Flush();
        void Clear();   
	}
}
