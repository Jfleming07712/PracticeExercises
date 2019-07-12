using System;

namespace Exercise8
{
    public class Program
    {
        



        public static void Main(string[] args)
        {
            NumberContainer container = new NumberContainer();
            Math doMath = new Math();
            UserInterface userInterface = new UserInterface();

            userInterface.GatherNumbers(container);

            doMath.AddTwoNumbers(container);
            doMath.SubtractTwoNumbers(container);
            doMath.MultiplyTwoNumbers(container);
            doMath.DivideTwoNumbers(container);
            doMath.ModTwoNumbers(container);

            userInterface.DisplayAnswer(container);
        }
    }
}
