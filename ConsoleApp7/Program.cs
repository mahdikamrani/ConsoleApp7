using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public static void pascal(int n)
            {
                int[][] pascal = new int[n + 1][];

                pascal[1] = new int[1 + 2];
                pascal[1][1] = 1;


                for (int i = 2; i <= n; i++)
                {
                    pascal[i] = new int[i + 2];
                    for (int j = 1; j < pascal[i].Length - 1; j++)
                        pascal[i][j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
                }

                // print results
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j < pascal[i].Length - 1; j++)
                    {
                        Console.Write(pascal[i][j] + " ");
                    }
                    Console.WriteLine();
                }
            }// مهدی کامرانی نژاد
        }
    }
}
