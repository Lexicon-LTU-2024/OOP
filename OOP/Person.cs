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
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public virtual void Do()
        {
            Console.WriteLine($"{this.GetType().Name} doing");
        }
    }

    internal class Employee : Person
    {
        public int Salary { get; set; }
        public Employee(string name, int salary) : base(name) 
        {
            Salary = salary;
        }

    }

    internal class Admin : Employee
    {
        public Admin() : base("Admin", 2500)
        {

        }

        public override void Do()
        {
            Name = "Admin";
            base.Do();
            Console.WriteLine("Admin doing2");
        }

        public void ADo()
        {
            Console.WriteLine("ABC");
        }

    }
}
