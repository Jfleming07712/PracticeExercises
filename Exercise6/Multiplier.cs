using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class Multiplier
    {
        public static void DoMultiplication(NumberContainer container)
        {

            //container.Number1 = 2;
            //container.Number2 = 3;
            //container.Number3 = 6;

            container.Result = container.Number1 * container.Number2 * container.Number3;

            Console.WriteLine("Result is " + container.Result);
        }

        
    }
}
