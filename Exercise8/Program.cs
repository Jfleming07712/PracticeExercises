using System;

namespace Exercise8
{
    public class Program
    {
        //Write a C# Sharp program that takes a number as input and print its multiplication table. Go to the editor
        //Test Data:
        //Enter the number: 5
        //Expected Output:
        //5 * 0 = 0
        //5 * 1 = 5
        //5 * 2 = 10 
        //5 * 3 = 15
        //....
        //5 * 10 = 50



        public static void Main(string[] args)
        {
            NumberContainer container = new NumberContainer();
            Math doMath = new Math();
            UserInterface userInterface = new UserInterface();

            userInterface.GatherNumbers(container);

            doMath.TimesTable(container);

        }
    }
}
