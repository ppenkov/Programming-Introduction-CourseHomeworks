﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            while (counter >= 1 && counter <= 100)
            {
                counter++;
                if (counter % 7 == 0 || counter % 11 == 0) 
                {
                    Console.WriteLine(counter);
                }
            }
        }
    }
}
