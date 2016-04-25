using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            //secret number
            int secret = 10;
            int counter = 0;
            int userGuess;

            //Get user guess
            //Console.WriteLine("Guess a number between 1 and 10");
            // int userGuess = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("userGuess" + secret);

            Console.WriteLine("Guess a number between 1 and 20");
            //userGuess = 2;
            //Console.ReadLine();

            do
            {
                
                userGuess = Convert.ToInt32(Console.ReadLine());


                if (counter == 4)
                {
                    Console.WriteLine(" you had " + counter + " guesses");
                }
                //user gues validation
                 else if (userGuess > 20 || userGuess < 1)
                {
                    Console.WriteLine(" Learn to read , you have to guess a number between 1 and 20. That was a guess! ");
                    counter++;
                }
                //Create a condition
                else if (userGuess == 10)
                {
                    Console.WriteLine(" you guessed the number");
                    counter ++;
                    Console.WriteLine(" you had " + counter + " guesses");
                }
                else if (userGuess > 10)
                {
                    Console.WriteLine("you guessed to high");
                    counter++;
                }

                else
                {
                    Console.WriteLine(" You guessed to low");
                    counter++;
                }
            }
            while ((userGuess != secret));

            

            //Stop the screen to close
            Console.ReadLine();

        }
    }
}




