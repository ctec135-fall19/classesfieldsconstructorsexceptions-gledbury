using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fields
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate the object
            Employee e = new Employee();

            // print default state
            e.PrintState();
            Console.WriteLine();

            e.SetName("George Ledburyyyyy");
            e.SetEmpId(50999999);
            e.setCurrPay(1234.50);
            e.PrintState();
            Console.WriteLine();
            Console.WriteLine("Name:");
        }
    }
}
