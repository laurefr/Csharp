using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please write 5 numbers to be average ");


            // Creating a new empty array of 5 elements
            int[] numArray = new int[5];


            // Getting the user inupt and addding it to the array.
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0;
            foreach (int value in numArray)
            {
                total = (value + total);
            }
            Console

        }
    }
}
