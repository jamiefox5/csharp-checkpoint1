using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (count < 4)
            {



                Console.WriteLine("Please enter a number between 1 and 10:");

                int number = int.Parse(Console.ReadLine());

                int random = new Random().Next(1, 11);
                Console.WriteLine(random);
                if (random == number)
                {
                    Console.WriteLine("You guess the correct number");
                    count = count + 1;
                }
                else
                {
                    Console.WriteLine("You lost, so sad!");
                    count = count + 1;
                }


            }
        }
    }
}
