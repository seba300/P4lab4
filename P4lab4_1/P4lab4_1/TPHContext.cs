using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4lab4_1
{
    public class TPHContext:DbContext
    {
        public DbSet<Computer> Computers { get; set; }
    }
}
