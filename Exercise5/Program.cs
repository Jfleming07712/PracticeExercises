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
                Console.WriteLine("enter your first number");
                var stringNumber1 = Console.ReadLine();

                //int n1;
                if (!int.TryParse(stringNumber1, out int n1))
                {
                    Console.WriteLine("not an int");
                    stringNumber1 = "wrong";
                    Input1();
                }

                Number1 = n1;
            }

            public void Input2()
            {
                bool valid = true;
                int n2;
                do
                {
                    Console.WriteLine("Enter your second number");
                    var stringNumber2 = Console.ReadLine();

                    //int n2;
                    if (!int.TryParse(stringNumber2, out n2))
                    {
                        Console.WriteLine("not an int");
                        valid = false;
                    }
                }
                while (valid == false);



                

                Number2 = n2;
            }
        }
    }
}
