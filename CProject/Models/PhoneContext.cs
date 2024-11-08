using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CProject.Models
{
    internal class PhoneContext : DbContext
    {
        public PhoneContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connectionString = "Server=ALEXANDRA;Database=PhonesDb1;Trusted_Connection=true;MultipleActiveResultSets=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Brand> Brand { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<User> User { get; set; }
    }
}
