﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edge = int.Parse(Console.ReadLine());
            if (edge <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            int area;
            area =(int)Math.Pow(edge,2)*6;
            
            Console.WriteLine(area);
        }
        

    }
}
