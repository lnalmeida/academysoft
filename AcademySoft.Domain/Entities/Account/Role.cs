﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySoft.Domain.Entities.Account
{
    public  class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Role() { }

    }
}
