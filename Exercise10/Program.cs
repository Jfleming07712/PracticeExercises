using System;

namespace Exercise10
{
    public class Program
    {
        //Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y).z and x.y + y.z. Go to the editor
        //Test Data:
        //Enter first number - 5
        //Enter second number - 6
        //Enter third number - 7
        
        //Expected Output:
        //Result of specified numbers 5, 6 and 7, (x+y).z is 77 and x.y + y.z is 72



        public static void Main(string[] args)
        {
            NumberContainer container = new NumberContainer();
            Math doMath = new Math();
            UserInterface userInterface = new UserInterface();

            userInterface.GatherNumbers(container);

            doMath.EquationOne(container);
            doMath.EquationTwo(container);


            userInterface.DisplayEquationOne(container);
            userInterface.DisplayEquationTwo(container);

        }
    }
}
