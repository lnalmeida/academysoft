using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySoft.Domain.Entities.Account
{
    public class UserRole
    {
        public User User { get; set; }
        public string RoleName { get; set; } = string.Empty;

        public UserRole() { }
    }
}
