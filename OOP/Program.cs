namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new("Kalle");
           

            var nameLength = person1.Name?.Length ?? 0;
            Admin admin = new Admin();
            Person person4 = new Employee("Emp", 25);


            Employee person3 = new Employee("Emp2", 30);

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
}
