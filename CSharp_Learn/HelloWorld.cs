﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Learn
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Hello World, {Console.ReadLine()}!");
            }
        }
    }
}
