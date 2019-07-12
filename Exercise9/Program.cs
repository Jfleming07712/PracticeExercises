using System;

namespace Exercise9
{
    public class Program
    {
        //Write a C# Sharp program that takes four numbers as input to calculate and print the average. Go to the editor
        //Test Data:
        //Enter the First number: 10 
        //Enter the Second number: 15 
        //Enter the third number: 20 
        //Enter the four number: 30 
        
        //Expected Output:
        //The average of 10 , 15 , 20 , 30 is: 18



        public static void Main(string[] args)
        {
            NumberContainer container = new NumberContainer();
            Math doMath = new Math();
            UserInterface userInterface = new UserInterface();

            userInterface.GatherNumbers(container);

            doMath.AverageFourNumbers(container);

            userInterface.DisplayAverageOfFourNumbers(container);

        }
    }
}
