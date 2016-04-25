using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            //secret number
            int secret = 10;
            int userGuess;

            //Get user guess
            //Console.WriteLine("Guess a number between 1 and 10");
            // int userGuess = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("userGuess" + secret);


            Console.ReadLine();

            do
            {
                Console.WriteLine("Guess a number between 1 and 10");
                userGuess = Convert.ToInt32(Console.ReadLine());

                //Create a condition
                if (userGuess == 10)
                { Console.WriteLine(" you guessed the number"); }

                else if (userGuess > 10)
                { Console.WriteLine("you guessed to high"); }

                else
                { Console.WriteLine(" You guessed to low"); }
            }
            while ((userGuess != 10));

            Console.WriteLine(" you guessed the number");
            
            //Stop the screen to close
            Console.ReadLine();

  

        }//end main
    }//program class
}//end namesapce
