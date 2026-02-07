using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathApp
{
    internal class MathProgram
    {
        static void Main(string[] args)
        {
            double A = 5.0;
            double B = -4.0; 

            Console.WriteLine($"A: {A}, B: {B}");

         
            double absoluteB = Math.Abs(B);
            Console.WriteLine($"Absolute value of B: {absoluteB}");

            double ASquared = Math.Pow(A, 2);
            double BSquared = Math.Pow(absoluteB, 2);

            double h = Math.Sqrt(ASquared + BSquared);
            Console.WriteLine($"Calculated to Hypotenuse: {h}");

            double longestSide = Math.Max(A, absoluteB);
            Console.WriteLine($"Longest initial : {longestSide}");

            double preciseResult = 10.5678;
            double roundedResult = Math.Round(preciseResult, 2);
            Console.WriteLine($"Rounded value of {preciseResult}: {roundedResult}");

            Console.ReadLine();
        }
    }
}
