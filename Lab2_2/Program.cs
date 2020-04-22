using System;

namespace OOP_lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double x = 0; x <  Math.PI; x += Math.PI / 20)
            {
                double y = Math.Tan(x) ;
                Console.WriteLine("x = {0:f4} y = {1:f4}", x, y);
            }
        }
    }
}