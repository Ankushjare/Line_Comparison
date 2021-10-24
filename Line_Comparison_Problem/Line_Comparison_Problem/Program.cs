using System;

namespace Line_Comparison_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Enter the value First of (x1,y1),(x2,y2) cordinates\n");
            int x1 = Convert.ToInt32(Console.ReadLine());
            int x2 = Convert.ToInt32(Console.ReadLine());
            int y1 = Convert.ToInt32(Console.ReadLine());
            int y2 = Convert.ToInt32(Console.ReadLine());
            int length1 = toFindLength(x1, y1, x2, y2);

            Console.WriteLine("Enter the value Second of (x1,y1),(x2,y2) cordinates\n");
            x1 = Convert.ToInt32(Console.ReadLine());
            x2 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            int length2 = toFindLength(x1, y1, x2, y2);

            Console.WriteLine(length1.Equals(length2));

            Console.WriteLine("Return value (comparison) =" + length1.CompareTo(length2));

        }
        private static int toFindLength(int x1, int y1, int x2, int y2)
        {
            return (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}