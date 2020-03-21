using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4lab4_1
{
    class TPTContext:DbContext
    {
        public DbSet<Computer> Computers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PC>().ToTable("Pecety");
            modelBuilder.Entity<Laptop>().ToTable("Laptop");
        }
    }
}
