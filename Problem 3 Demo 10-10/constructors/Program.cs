using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.PrintState();
            Console.WriteLine();

            Employee e2 = new Employee("George Ledbury");
            e2.PrintState();
            Console.WriteLine();

            Employee e3 = new Employee("George, 5090909, 123450");
            e3.PrintState();

        }
    }
}
