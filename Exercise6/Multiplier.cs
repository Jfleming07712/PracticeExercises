using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise6
{
    public class Multiplier
    {
        public int DoMultiplication()
        {
            var container = new NumberContainer();

            container.Number1 = 2;
            container.Number2 = 3;
            container.Number3 = 4;

            container.Result = container.Number1 * container.Number2 * container.Number3;

            return container.Result;
        }
    }
}
