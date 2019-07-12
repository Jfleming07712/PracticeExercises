using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise8
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

        public double TimesTable(NumberContainer container)
        {
            
        }

    }
}
