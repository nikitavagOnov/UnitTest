﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 2, 3, 5 }, { 7, 2, 1 } };
            Method(array, 5);
            Console.ReadKey();
        }

        public static int[,] Method(int[,] array, int value)
        {
            int[,] result = new int[array.GetLength(0), array.GetLength(1)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int sum = 0;
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                    if (sum % value == 0 && array[i, j] % value == 0)
                    {
                        result[i, j] = value;
                    }
                }
            }
            return result;
        }
    }
}
