using System;

namespace Exercise7
{
    public class Program
    {
        //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of 
        //two numbers which will be entered by the user. Go to the editor
        //Test Data:
        //Input the first number: 25
        //Input the second number: 4
        //Expected Output:
        //25 + 4 = 29
        //25 - 4 = 21
        //25 x 4 = 100 
        //25 / 4 = 6
        //25 mod 4 = 1

        
        
        



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
