namespace OOP;

internal class Program
{
    static void Main(string[] args)
    {

        Employee person3 = new Employee("Emp2", 30);
        Person person1 = new("Kalle");
       // person1.Name = "Nisse";
       

        var nameLength = person1.Name?.Length ?? 0;
        Admin admin = new Admin();
        Person person4 = new Employee("Emp", 25);



        List<Person> list = new List<Person>() 
        { 
            person1, 
            admin, 
            person3 
        };

        foreach (Person person in list)
        {
            //Admin admin2 = (Admin)person;
            //if(person is Admin admin3)
            //{
            //    Admin admin2 = (Admin)person;
            //    admin2.ADo();

            //    admin3.ADo();
            //}
            person.Do();


        }

    }
}
