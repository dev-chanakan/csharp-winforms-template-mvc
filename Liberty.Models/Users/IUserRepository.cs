using Liberty.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Models.Users
{
    public interface IUserRepository : IRepository<User, Guid>
    {
        bool IsAuthentication(string username, string passwordEncrypt);
        User FindByUserName(string username);
    }
}
