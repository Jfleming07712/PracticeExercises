using System;

namespace Exercise6
{
    public class Program
    {
        //Write a C# Sharp program to print the output of multiplication of three numbers which will be entered 
        //by the user. 
        //Test Data:
        //Input the first number to multiply: 2
        //Input the second number to multiply: 3
        //Input the third number to multiply: 6
        //Expected Output:
        //2 x 3 x 6 = 36

        
        
        



        public static void Main(string[] args)
        {
            NumberContainer container = new NumberContainer();
            Multiplier multiplyThreeNumbers = new Multiplier();
            UserInterface userInterface = new UserInterface();

            userInterface.GatherNumbersToMultiply(container);

            multiplyThreeNumbers.DoMultiplication(container);

            userInterface.DisplayAnswer(container);
        }
    }
}
