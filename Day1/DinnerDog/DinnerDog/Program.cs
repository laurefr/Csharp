using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerDog
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            //Create a for loop
          //  for (int i = 0; i < sevenDwarves.Length; i++)
        

            {
                //Create an user input for dinner
                string[] dinnerdog = new string[7];
                for (int i = 0; i < dinnerdog.Length; i++ )
                {
                    Console.WriteLine("what would like to eat for dinner"+" " + sevenDwarves[i] + "" + "?");
                    //readline can not be forgotten as if the progamme will not read the code properly...
                    Console.ReadLine();
                 
                }
                string dinner = null;
                foreach ( string value in sevenDwarves)
                {
                    dinner = (value + dinner);
                }
                Console.ReadLine();

                //create another array for the drink
                string[] drinkDog = new string [7];
                for ( int i =0; i<drinkDog.Length; i ++)
                {
                    Console.WriteLine(" What would you like to drink with you dinner" + " " + sevenDwarves[i] + "" + "?");
                    Console.ReadLine();
                }
                string drink = null; 
                foreach (string value in sevenDwarves)
                {
                    drink = (value + drink);
                }
                Console.ReadLine();
                Console.WriteLine(" Enjoy your meal" + sevenDwarves);
            }
        }

    }
}
