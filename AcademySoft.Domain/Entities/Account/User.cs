using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySoft.Domain.Entities.Account
{
    public class User : IdentityUser
    {
        public string Name { get; set; } = string.Empty;
    }
}
