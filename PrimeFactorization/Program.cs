using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
namespace PrimeFactorization;

/*
    Created by tuannguyencs
    Problem - Have the user enter a number and find all Prime Factors (if there are any) and display them.
*/

public class Program
{
    static void Main(string[] args)
    {
        // Declaring variables, list for prime factors
        List<int> factors = new();
        int testFactor = 1;
        int input = 0;

        // Any number less than 1 cannot be prime
        while (input <= 1)
        {
            try
            {
                Console.Write("Enter a number to check for prime factors: ");
                input = Convert.ToInt32(Console.ReadLine());
                if (input < 2) { Console.WriteLine("Choose a number greater than 1."); }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
                continue;
            }
        }

        // Dividing by factors every time it finds one starting from the lowest
        while (++testFactor <= input)
        {
            if (input % testFactor == 0)
            {
                factors.Add(testFactor);
            }

            while (input % testFactor == 0)
            {
                input /= testFactor;
            }
        }

        // Formatting
        var last = factors.Last();
        Console.Write("Prime factors: ");

        // Printing
        foreach (int val in factors)
        {
            if (val.Equals(last))
            {
                Console.Write($"{val}");
            }
            else
            {
                Console.Write($"{val}, ");
            }
        }

        Console.WriteLine();
    }
}