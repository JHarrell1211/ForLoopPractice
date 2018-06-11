using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_I
{
    class Program
    {
        static void Main(string[] args)
        {
            //Display the first 10 natural numbers

            int i;
            int x = 0;

            for(i = 1; i <= 10; i++)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();

            //Sum of first 10 natural numbers
            
            for(i = 1; i <= 10; i++)
            {
                x = x + i;
            }
            Console.WriteLine(x);

            // Add x number of odd numbers 
            Console.WriteLine("How many odd numbers do you want to add");
            x = int.Parse(Console.ReadLine());
            int odd;
            int sum = 0;

            for(i = 1; i <= x; i++)
            {
                odd = (2 * i) - 1;
                Console.WriteLine(odd);
                sum = sum + odd;
            }
            Console.WriteLine("The sum of " + x + " odd numbers is " + sum);


            //Add value of 10 user input numbers
            int n;
            sum = 0;
            for(i = 1; i <= 10; i++)
            {
                n = int.Parse(Console.ReadLine());
                sum = sum + n;
            }
            Console.WriteLine(sum);
        }
    }
}
