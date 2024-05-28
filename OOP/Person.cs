using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{

    internal interface IPerson
    {
        string Name { get; set; }
        void Do();
       // void Do2();
    }

    internal class Person : IPerson
    {
        public string? Name { get; set; } //= string.Empty;
        public void Do()
        {
            Console.WriteLine("Person doing");
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }

    }

    internal class Admin : Employee
    {
        public void ADo()
        {
            Console.WriteLine("Admin doing");
        }
    }
}
