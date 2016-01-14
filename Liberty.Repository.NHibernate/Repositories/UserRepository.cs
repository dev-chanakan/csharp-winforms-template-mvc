using Liberty.Infrastructure.UnitOfWork;
using Liberty.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Linq;

namespace Liberty.Repository.NHibernate.Repositories
{
    public class UserRepository : Repository<User, Guid>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork)
			: base(unitOfWork)
		{
		}

        public bool IsAuthentication(string username, string passwordEncrypt)
        {
            return this.FindAll().Where(e => e.Password == passwordEncrypt).Any();
        }

        public User FindByUserName(string username)
        {
            return this.FindAll().Where(e => e.Username == username).FirstOrDefault();
        }
    }
}
