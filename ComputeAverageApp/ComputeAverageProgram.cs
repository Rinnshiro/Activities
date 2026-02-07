using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;


namespace ComputeAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 5;
            Console.WriteLine("Enter 5 grades separated by new line:");
            for (int i = 0; i < count; i++)
            {
                if (int.TryParse(Console.ReadLine(), out int grade))
                {
                    sum += grade;
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter number.");
                    i--; 
                }
            }
            double average = (double)sum / count;
            int rAverage = (int)Math.Round(average); 

            Console.WriteLine($"The average is {average} and round off to {rAverage}");
            Console.WriteLine("Press any key to exit..........");
            Console.ReadKey(true);
        }
    }
}

