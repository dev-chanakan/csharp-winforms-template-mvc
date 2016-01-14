using Liberty.Infrastructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liberty.Models.Users
{
    public class User : Entity<Guid>
    {
        public virtual string Username { get; set; }
        public virtual string Password { get; set; }
        public virtual DateTime? LastLogin { get; set; }
        public virtual string DisplayName { get; set; }
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
    }
}
