using System;

namespace PointDemo
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        // 建構子constructors
        public Point(double a, double b) // 名稱跟類別相同
        {
            X = a;
            Y = b;
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            Point p2 = new Point(30, 40);
            
            Console.WriteLine("{0} {1}", p1, p2);
        }
    }
}
