using System;

namespace Exercise4
{
    class Program
    {
        ////    4. Write a C# Sharp program to print the result of the specified operations. 
        ////    Test data:
        
        ////    -1 + 4 * 6
        ////    ( 35+ 5 ) % 7
        ////    14 + -4 * 6 / 11
        ////    2 + 15 / 6 * 1 - 7 % 2
        static void Main(string[] args)
        {
            var result1 = -1+4*6;
            var result2 = (35+5)%7 ;
            var result3 = 14+(-4)*6/11;
            var result4 = 2+15/6*1-7%2;
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
        }
    }
}
