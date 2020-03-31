using System;

namespace HW_21_03_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////////////// 1
            double a = 16.80, b = 12.40;
            double c = Math.Sqrt(a*b);
            Console.WriteLine(c);
            ///////////////// 2
            double pointA = 1.40, pointB = -5.50, pointC = 0.60;
            double lengthAC = Math.Abs(pointA-pointC);
            System.Console.WriteLine(lengthAC);
            double lengthBC = Math.Abs(pointB-pointC);
            System.Console.WriteLine(lengthBC);
            double summ = Math.Abs(lengthAC+lengthBC);
            System.Console.WriteLine(summ);
            ////////////////// 3
            double x1 = -6.20, y1 = 5.20, x2 = 2.10, y2 = 9.80;
            double r = Math.Sqrt( Math.Pow((x1 - x2), 2) + Math.Pow((y1-y2),2));
            System.Console.WriteLine(r);
            ////////////////// 4
            int a1 = 41;
            int d1 = a1/10;
            int c1 = a1%10;
            int n = c1*10+d1;
            System.Console.WriteLine(n);
            ////////////////// 5
            int sec = 10985;
            int min = sec/60;
            int hour = min/60;
            int day = hour/24;
            System.Console.WriteLine();
            ////////////////// 6
            int nDay = 202;
            int nWeek = nDay%7;
            System.Console.WriteLine(nWeek);

        }
    }
}
