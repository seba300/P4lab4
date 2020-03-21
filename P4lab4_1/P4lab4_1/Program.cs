using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tph = new TPHContext();
            tph.Computers.Add(new PC() { CoolingType = "Liquid", Decription = "Gaming PC" });
            tph.SaveChanges();

            var tpt = new TPTContext();
            tpt.Computers.Add(new PC() { CoolingType = "Liquid", Decription = "Gaming PC" });
            tpt.SaveChanges();

            var tpc = new TPCContext();
            tpc.Computers.Add(new PC() { CoolingType = "Liquid", Decription = "Gaming PC" });
            tpc.SaveChanges();
            Console.WriteLine("ready");

        }
    }
}
