﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals3
{
    class Program
    {
        static bool isAlive = true; // true = alive, false = dead
        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals3");

            if (isAlive)
            {
                Console.WriteLine("You are alive :)");
            }
            else
            {
                Console.WriteLine("You are dead ):");
            }
            Console.ReadKey(true);
        }
    }
}
