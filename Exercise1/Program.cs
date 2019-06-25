using System;

namespace Exercise1
{
    //1. Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
    //Expected Output : 
    //Hello: Alexandra Abramov
    public class Program
    { 

        public static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");

            Person user = new Person
            {
                Name = Console.ReadLine()
            };


            var result = ($"Hello: \n{user.Name}");

            Console.WriteLine($"{result}");

        }
    }
}
