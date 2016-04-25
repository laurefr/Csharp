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
            //Create an string array for the name of the dwarves
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };
            
            {
                //Create an illimited array ( any answers are true) running the number of time of the first string array
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
                // you can't mix string with number or int with string for a foreach
                // when using a string  for a foreach write null
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
