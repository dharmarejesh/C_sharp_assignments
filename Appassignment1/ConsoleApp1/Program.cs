using System;

namespace Name
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Enter Your Name ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            string userName = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Console.WriteLine("Hello {0} ", userName);
            Console.WriteLine();

            //Console.WriteLine("Hello " + userName);
        }

    } 
}
namespace Hello
{
    public class Person
    {
        public string Name = default!;
        public void Introduce(string to)
        {
            System.Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "John";
            person.Introduce("Mary");
        }
    }
}

