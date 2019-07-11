using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class UserInterface
    {
        public static void GatherNumbersToMultiply(NumberContainer container)
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
                    container.Number1 = n1;
                    valid = true;
                }
            }

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
                    container.Number2 = n2;
                    valid2 = true;
                }
            }

            bool valid3 = false;
            while (valid3 == false)
            {
                Console.WriteLine("enter your second number");
                var stringNumber3 = Console.ReadLine();

                if (!int.TryParse(stringNumber3, out int n3))
                {
                    Console.WriteLine("not an int");
                }
                else
                {
                    container.Number3 = n3;
                    valid3 = true;
                }
            }

        }

    }
}
