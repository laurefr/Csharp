using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tell user who is standing for the election
            Console.WriteLine(" Trump, Clinton, Bernie, Ben are running to be the next President of America");
            Console.WriteLine(" who do you think will win the election?");
            //Create a string
            string nextPresident = (Console.ReadLine().ToLower());

            string reply = nextPresident;
           // Console.WriteLine(reply);

            switch (nextPresident)
            {
                case"clinton":
                    reply= "She be the first woman to be President in the USA... USA love to make history..";
                    break;

                case "trump":
                    reply= "God Help America";
                    break;

                default:
                    reply = "Please type a name ";
                    break;       
            }
            // end of swtich ... write code after the end of switch for the code to run
            // Create an user output....
            //Create a string for the reply of the sitch statement
           

            string userOutput = (   nextPresident +  " " +  reply);
            Console.WriteLine(  userOutput  );

            Console.ReadLine();
        }
    }
}
