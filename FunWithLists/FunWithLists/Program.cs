using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLists
{
    class Program
    {
        static void Main(string[] args)
        {
           

            //declare a new list of strings for a menu
            List<string> myMenu = new List<string>() 
            { "Pizza", "Sushi", "Hummus", "Twix" };

            //add one more menu item to our list
            myMenu.Add("Ice Cream");

            //loop through our menu and print each item
            for (int i = 0; i < myMenu.Count; i++)
            {
                Console.WriteLine(myMenu[i]);
            }

            //remove things from a list
            myMenu.Remove("Pizza");
            myMenu.RemoveAt(1);

            //Another EASIER way of printing out an array
            Console.WriteLine(string.Join(", ",myMenu));

            //Loop through the list again, to make Twix pop

            for (int i = 0; i < myMenu.Count; i++)
            {
                //set a variable equal to the current item in our list
                string item = myMenu[i];
                //convert the item to a lowercase and search it for the word "twix"
                if (item.ToLower().Contains("i"))
                {
                    //found a twix, make it capitlized
                    Console.WriteLine(item.ToUpper());
                }
                else
                {
                    //print everything else normally
                    Console.WriteLine(item);
                }
            }


            //keep console window open
            Console.ReadKey();
        }
    }
}
