using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //call the HelloWorld function
            HelloWorld();

            //call the greeting function
            Greet("Anthony");

            //call the DoubleIt function
            int myAgeDoubled = DoubleIt(28);
            Console.WriteLine(myAgeDoubled);
            Console.WriteLine(DoubleIt(myAgeDoubled));

            //call the multiply function
            Console.WriteLine(Multiply(myAgeDoubled, 9));

            //do a loop from 1->20 that triples each number
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.WriteLine(Multiply(i, 3));
            }

            //keep the console window open
            Console.ReadKey();
        }
        //Functions go below here
        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        //next function goes here
        static void Greet(string name)
        {
            Console.WriteLine("Hello, " + name);
        }
        //next function goes here
      
        static int DoubleIt(int num)
        {
            return num * 2;
        }
        //next function goes here
        /// <summary>
        /// This function multiplies
        /// </summary>
        /// <param name="num1">the first number to be multiplied</param>
        /// <param name="num2">the second number to be multiplied</param>
        /// <returns>The results of both numbers multiplied</returns>
        static int Multiply(int num1, int num2) 
        {
            return num1 * num2;
        }
    }
}
