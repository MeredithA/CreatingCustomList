﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingCustomLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> test = new CustomList<int>();

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);
            test.Add(5);

            test.Remove(5);            

            Console.ReadLine();
        }
    }
}
