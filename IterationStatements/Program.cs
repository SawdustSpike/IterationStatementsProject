using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace IterationStatements
{
    class Program
    { 
        static void Main(string[] args)
            {
            for (int y = 0; y < 15; y++)
            {
                Console.WriteLine($"{y}");
            }
                var numbers = new List<int>();            
                var num = 0;                      
            do
            {
                num++;
                numbers.Add(num);
            }
            while (num < 100);
            while (num < 200)
            {
                num++;
                numbers.Add(num);
            }
            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");
            foreach (var x in numbers)
            {
                Console.WriteLine(x);
            }

                // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers



                Console.WriteLine("");
            Console.WriteLine("Decrease:");

            for (int i=199; i< numbers.Count && i >=0; i--)
            {
                Console.WriteLine(i);
            }
            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            {
                // place numbers[i] inside of the Console.WriteLine() method
            }

            //------------End of exercise
        }
        /* static void Dry(int a, int b)
        {
            a++;
            b.Add(a); 
        } */
    }
}
