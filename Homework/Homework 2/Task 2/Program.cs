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
            Console.WriteLine("Enter your points from 1 to 9:");
            int bonus = int.Parse(Console.ReadLine());
           
            if (bonus >= 1 && bonus <= 3)
            {
                Console.WriteLine("Bonus points:" + bonus * 5);
            }
            else if (bonus >= 4 && bonus <= 6)
            {
                Console.WriteLine("Bonus points:" + bonus * 10); 
            }
            else if (bonus >= 7 && bonus <= 9)
            {
                Console.WriteLine("Bonus points:" + bonus * 50);
            }
        }
    }
}
