using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparisionProblem
{
    public class UC1
    {
        public void calculatecoridinates()
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Enter the value of (x1,y1),(x2,y2) cordinates");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(toFindLength(x1, y1, x2, y2));
        }
        private static int toFindLength(int x1, int y1, int x2, int y2)
        {
            return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}