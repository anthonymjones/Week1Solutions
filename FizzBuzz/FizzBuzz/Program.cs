using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            //create for loop from 1 to 35
            for(int i = 1; i <= 3500; i++)
            {
                FizzBuzz(i);
            }

            //keep the console window open
            Console.ReadKey();
        }
        //new functions below
        //FizzBuzz takes in a number and prints FizzBuzz, Fizz, or Buzz
        static void FizzBuzz(int number)
        {
            if(number % 3 == 0 && number % 5 == 0)
            {
                //number is divisble by 5 and 3
                Console.WriteLine("FizzBuzz");
            }
            else if(number % 5 == 0)
            {
                //number is only divisible by 5
                Console.WriteLine("Fizz");
            }
            else if(number % 3 == 0)
            {
                //number is only divisible by 3
                Console.WriteLine("Buzz");
            }
            else
            {
                //number is not divisible by 5 or 3
                Console.WriteLine(number);
            }
        }
    }
}
