﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello world!");
            Console.WriteLine("What number range?(smaller number first)");
            int lower = Convert.ToInt32(Console.ReadLine());
            int upper = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            int r = rand.Next(lower, upper);
            //Console.WriteLine(r);
            Console.WriteLine();
            int guess = 0;
            int guess_amt = 0;
            while (guess != r)
            {
                Console.WriteLine("What's my number?(between "+ lower + " and " + upper + ")");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == r)
                {
                    Console.WriteLine(guess + " is correct!");
                    guess_amt++;
                    Console.WriteLine("it took you " + guess_amt + " tries.");
                    Console.WriteLine("press enter to exit");
                    Console.ReadLine();
                }

                else if (guess < r)
                {
                    Console.WriteLine(guess + " is too low!");
                    guess_amt++;
                }

                else if (guess > r)
                {
                    Console.WriteLine(guess + " is too high!");
                    guess_amt++;
                }
            }
            
        }
    }
}
