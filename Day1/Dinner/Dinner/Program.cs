using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinner
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            for (int i = 0; i < sevenDwarves.Length; i++)
            {
                Console.WriteLine(sevenDwarves[i] + "your dinner is ready!");
            }

    
        // foreach
            foreach (string value in sevenDwarves)
             {
                    Console.WriteLine(value + " do not forget to drink");
             }

            string[] myString = new string [7]