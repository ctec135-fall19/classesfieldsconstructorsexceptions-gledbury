using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate object
            Employee e = new Employee();

            e.Name = "George Ledbury";
            e.ID = 5050505;
            e.Pay = 1234.50;

            e.PrintState();

        }
    }
}
