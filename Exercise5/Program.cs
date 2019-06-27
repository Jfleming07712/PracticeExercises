using System;

namespace Exercise5
{
    class Program
    {
        //      Write a C# Sharp program to swap two numbers.
        //      Test Data:
        //      Input the First Number : 5
        //      Input the Second Number : 6
        //      Expected Output: 
        //      After Swapping :
        //      First Number : 6 
        //      Second Number : 5 


        static void Main(string[] args)
        {

            var container = new NumberContainer();

            container.Input1();
            container.Input2();

            Console.WriteLine("pre switch");
            Console.WriteLine(container.Number1);
            Console.WriteLine(container.Number2);

            container.Swap(container);

            Console.WriteLine("post switch");
            Console.WriteLine(container.Number1);
            Console.WriteLine(container.Number2);
        }
        public class NumberContainer
        {
            public int Number1 { get; set; }
            public int Number2 { get; set; }

            public void Swap(NumberContainer container)
            {
                int tempNumber = container.Number1;
                container.Number1 = container.Number2;
                container.Number2 = tempNumber;
            }

            public void Input1()
            {
                bool valid = false;
                while (valid == false)
                {
                    Console.WriteLine("enter your first number");
                    var stringNumber1 = Console.ReadLine();

                    if (!int.TryParse(stringNumber1, out int n1))
                    {
                        Console.WriteLine("not an int");
                    }
                    else
                    {
                        Number1 = n1;
                        valid = true;
                    }
                }
            }

            public void Input2()
            {
                bool valid2 = false;
                while (valid2 == false)
                {
                    Console.WriteLine("enter your second number");
                    var stringNumber2 = Console.ReadLine();

                    if (!int.TryParse(stringNumber2, out int n2))
                    {
                        Console.WriteLine("not an int");
                    }
                    else
                    {
                        Number2 = n2;
                        valid2 = true;
                    }
                }
            }
        }
    }
}
