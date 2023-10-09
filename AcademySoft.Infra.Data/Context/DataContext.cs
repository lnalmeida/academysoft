using AcademySoft.Domain.Entities.Account;
using AcademySoft.Infra.Data.DataConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademySoft.Infra.Data.Context
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(new UserConfiguration().Configure);
            base.OnModelCreating(modelBuilder);
        }
    }
}
