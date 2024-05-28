using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP;


internal interface IPerson
{
    string Name { get; }
    void Do();
   // void Do2();
}

internal class Person : IPerson
{
    public string Name { get; protected set; }

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
    private int _salary;

    public int Salary
    {
        get { return _salary; }
        set 
        { 
            if(value < 10)
            {
                throw new ArgumentException();
            }
            _salary = value; 
        }
    }

   // public int Salary { get; set; }

    public Employee(string name, int salary) : base(name) 
    {
        Salary = salary;
    }

}

internal sealed  class Admin : Employee
{
    public Admin() : base("Admin", 2500)
    {

    }

    public sealed override void Do()
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

internal class SuperUser : Admin
{
     
}
