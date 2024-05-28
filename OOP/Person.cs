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
        public string Name { get; set; } = string.Empty;
        public virtual void Do()
        {
            Console.WriteLine($"{this.GetType().Name} doing");
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }

    }

    internal class Admin : Employee
    {

        public override void Do()
        {
            base.Do();
            Console.WriteLine("Admin doing2");
        }

    }
}
