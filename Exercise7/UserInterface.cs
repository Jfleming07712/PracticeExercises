using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7
{
    public class UserInterface
    {
        public void GatherNumbers(NumberContainer container)
        {
            var done = false;
            bool valid = false;
            while (valid == false)
            {
                Console.WriteLine("enter your first number");
                var stringNumber1 = Console.ReadLine();

                if (!double.TryParse(stringNumber1, out double n1))
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
            while (valid2 == false && done == false)
            {
                Console.WriteLine("enter your second number or enter done");
                var stringNumber2 = Console.ReadLine();

                if (stringNumber2 == "done")
                {
                    done = true; 
                }
                else
                {
                    if (!double.TryParse(stringNumber2, out double n2))
                    {
                        Console.WriteLine("not an int");
                    }
                    else
                    {
                        container.Number2 = n2;
                        valid2 = true;
                    }

                    
                }
            }

            bool valid3 = false;
            while (valid3 == false && done == false)
            {
                Console.WriteLine("enter your third number or enter done.");
                var stringNumber3 = Console.ReadLine();

                if (stringNumber3 == "done")
                {
                    done = true;
                }
                else
                {
                    if (!double.TryParse(stringNumber3, out double n3))
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

        public void DisplayAnswer(NumberContainer container)
        {
            Console.WriteLine( container.Number1 + " + " + container.Number2 + " = " + container.Result1);
            Console.WriteLine(container.Number1 + " - " + container.Number2 + " = " + container.Result2);
            Console.WriteLine(container.Number1 + " * " + container.Number2 + " = " + container.Result3);
            Console.WriteLine(container.Number1 + " / " + container.Number2 + " = " + container.Result4);
            Console.WriteLine(container.Number1 + " Mod " + container.Number2 + " = " + container.Result5);
        }

    }
}
