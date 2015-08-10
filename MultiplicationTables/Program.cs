using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTables
{
    //Write a program that calculates and displays a multiplication table exactly as shown below.

    //1 2 3 4 5 6 7 8 9
    //2 4 6 8 10 12 14 16 18
    //3 6 9 12 15 18 21 24 27
    //4 8 12 16 20 24 28 32 36
    //5 10 15 20 25 30 35 40 45
    //6 12 18 24 30 36 42 48 54
    //7 14 21 28 35 42 49 56 63
    //8 16 24 32 40 48 56 64 72
    //9 18 27 36 45 54 63 72 81

    class Program
    {
        static void Main(string[] args)
        {
            //declare two factors, i and j;
            int i;
            int j;

            //stopping this loop at i<10 means that i will be 9 in final multiplication operation
            for (i = 1; i < 10; i++)
            {
                //stopping this loop at j<10 means that j will be 9 in final multiplication operation
                for (j = 1; j < 10; j++)
                {
                    Console.Write(i*j + " ");

                    //each row will go only as far as i * 9
                    if (j == 9)
                    {
                        Console.WriteLine();
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
