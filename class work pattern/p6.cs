﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_work_pattern
{
    internal class p6
    {
        static void Main(string[] args)
        {
            for (int r = 1; r <= 5; r++)
            {
                for (int c = 1; c <= 5; c++)
                {
                    if (c == 1 || c == 5 || r+c == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine("");
            }
        }
    }
}