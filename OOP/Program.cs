namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();
            var nameLength = person.Name?.Length ?? 0;
            Person person2 = new();

        }
    }
}
