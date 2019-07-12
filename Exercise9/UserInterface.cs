using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
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

            bool valid4 = false;
            while (valid4 == false && done == false)
            {
                Console.WriteLine("enter your fourth number or enter done.");
                var stringNumber4 = Console.ReadLine();

                if (stringNumber4 == "done")
                {
                    done = true;
                }
                else
                {
                    if (!double.TryParse(stringNumber4, out double n4))
                    {
                        Console.WriteLine("not an int");
                    }
                    else
                    {
                        container.Number4 = n4;
                        valid4 = true;
                    }


                }
            }

        }

        public void DisplayAnswerForAllOperators(NumberContainer container)
        {
            Console.WriteLine( container.Number1 + " + " + container.Number2 + " = " + container.Result1);
            Console.WriteLine(container.Number1 + " - " + container.Number2 + " = " + container.Result2);
            Console.WriteLine(container.Number1 + " * " + container.Number2 + " = " + container.Result3);
            Console.WriteLine(container.Number1 + " / " + container.Number2 + " = " + container.Result4);
            Console.WriteLine(container.Number1 + " Mod " + container.Number2 + " = " + container.Result5);
        }

        public void DisplayAverageOfFourNumbers(NumberContainer container)
        {
            Console.WriteLine("The average of " + container.Number1 + "," + container.Number2 + "," + container.Number3 
                + " and " + container.Number4 + " is " + container.Result );
        }

    }
}
