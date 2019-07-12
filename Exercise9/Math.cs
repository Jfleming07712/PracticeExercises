using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise9
{
    public class Math
    {
        public double MultiplyThreeNumbers(NumberContainer container)
        {
            container.Result = container.Number1 * container.Number2 * container.Number3;
            return container.Result;
        }

        public double AddTwoNumbers(NumberContainer container)
        {
            container.Result1 = container.Number1 + container.Number2;
            return container.Result;
        }

        public double SubtractTwoNumbers(NumberContainer container)
        {
            container.Result2 = container.Number1 - container.Number2;
            return container.Result;
        }

        public double MultiplyTwoNumbers(NumberContainer container)
        {
            container.Result3 = container.Number1 * container.Number2;
            return container.Result;
        }

        public double DivideTwoNumbers(NumberContainer container)
        {
            container.Result4 = container.Number1 / container.Number2;
            return container.Result;
        }

        public double ModTwoNumbers(NumberContainer container)
        {
            container.Result5 = container.Number1 % container.Number2;
            return container.Result;
        }

        public void TimesTable(NumberContainer container)
        {
            int i = 0;
            while (i < 11)
            {
                container.Result = container.Number1 * i;
                Console.WriteLine(container.Number1 + " * " + i + " = " + container.Result);
                i++;
            }
        }

        public double AverageFourNumbers(NumberContainer container)
        {
            container.Result = (container.Number1 + container.Number2 + container.Number3 + container.Number4) / 4;

            return container.Result;
        }

    }
}
