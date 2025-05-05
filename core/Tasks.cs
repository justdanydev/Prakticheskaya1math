using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_practice1.core
{
    internal class Tasks
    {
        public void Task1()
        {
            double R, t, l;

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение l: ");
            l = Convert.ToDouble(Console.ReadLine());

            R = 3 * Math.Pow(t, 2) + 3 * Math.Pow(l, 5) + 4.9;

            Console.WriteLine($"R = {R}");
        }
        public void Task2()
        {
            double K, p, y, e;

            e = 2.7;

            Console.WriteLine("Введите значение p: ");
            p = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            K = Math.Log(Math.Pow(p, 2) + Math.Pow(y, 3)) + Math.Pow(e, p);

            Console.WriteLine($"K = {K}");
        }
        public void Task3()
        {
            double G, n, y;

            Console.WriteLine("Введите значение n: ");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            G = n * (y + 3.5) + Math.Sqrt(y);

            Console.WriteLine($"G = {G}");
        }
        public void Task4()
        {
            double D, a, t;

            Console.WriteLine("Введите значение a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Acos(Math.Pow(t, 5));

            Console.WriteLine($"D = {D}");
        }
        public void Task5()
        {
            double L, x;

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            L = 1.51 * Math.Acos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3);

            Console.WriteLine($"L = {L}");
        }
        public void Task6()
        {
            double M, y, e, x;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            M = Math.Acos(2 * y) + 3.6 * Math.Pow(e, x);

            Console.WriteLine($"M = {M}");
        }
        public void Task7()
        {
            double N, m;

            Console.WriteLine("Введите значение m: ");
            m = Convert.ToDouble(Console.ReadLine());

            N = Math.Pow(m, 2) + 2.8 * Math.Abs(m) + 0.55;

            Console.WriteLine($"N = {N}");
        }
        public void Task8()
        {
            double T, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            T = Math.Sqrt(Math.Abs(6 * Math.Pow(y, 2) - 0.1 * y + 4));

            Console.WriteLine($"T = {T}");
        }
        public void Task9()
        {
            double V, y, x;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            V = Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4));

            Console.WriteLine($"V = {V}");
        }
        public void Task10()
        {
            double U, e, y, k, x;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            U = Math.Pow(e, y) + 7.355 * Math.Pow(k, 2) + Math.Sin(Math.Pow(x, 2));

            Console.WriteLine($"U = {U}");
        }
        public void Task11()
        {
            double S, y, x;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            S = 9.756 * Math.Pow (y, 7) +  2 * Math.Tan(x);

            Console.WriteLine($"S = {S}");
        }
        public void Task12()
        {
            double K, t, x;

            Console.WriteLine("Введите значение t: ");
            t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            K = 7 * Math.Pow(t, 2) + 3 * Math.Sin(Math.Pow(x, 3)) + 9.2;

            Console.WriteLine($"K = {K}");
        }
        public void Task13()
        {
            double E, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            E = Math.Sqrt(Math.Abs(3 * Math.Pow(y, 2) + 0.5 * y + 4));

            Console.WriteLine($"E = {E}");

        }
        public void Task14()
        {
            double R, y, x, e;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            R = Math.Abs(Math.Sqrt(Math.Sin(Math.Pow(y, 2)) + 6.835) + Math.Pow(e, x));

            Console.WriteLine($"R = {R}");
        }
        public void Task15()
        {
            double H, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            H = Math.Sin(Math.Pow(y, 2)) - 2.8 * y + Math.Sqrt(Math.Abs(y));

            Console.WriteLine($"H = {H}");

        }
        public void Task16()
        {
            double S, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            S = Math.Sqrt(Math.Acos(4 * Math.Pow(y, 2)) + 7.151);

            Console.WriteLine($"S = {S}");
        }
        public void Task17()
        {
            double N, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            N = 3 * Math.Pow(y, 2) + Math.Sqrt(y + 1);

            Console.WriteLine($"N = {N}");

        }
        public void Task18()
        {
            double Z, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Z = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Pow(y, 3) + 1);

            Console.WriteLine($"Z = {Z}");

        }
        public void Task19()
        {
            double P, n, y, g;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение n: ");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение g: ");
            g = Convert.ToDouble(Console.ReadLine());

            P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);

            Console.WriteLine($"P = {P}");

        }
        public void Task20()
        {
            double U, e, k, y, x;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение k: ");
            k = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            double Sum = k + y;
            e = 2.7;

            U = Math.Pow(e, Sum) + Math.Tan(x) * Math.Sqrt(y);

            Console.WriteLine($"U = {U}");


        }
        public void Task21()
        {
            double P, e, y, h;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());

            double Sum = y + 5.5;

            e = 2.7;

            P = Math.Pow(e, Sum) + Math.Pow(h, 3);

            Console.WriteLine($"P = {P}");

        }
        public void Task22()
        {
            double T, u, y, x;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значениеx x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение u: ");
            u = Convert.ToDouble(Console.ReadLine());

            T = Math.Sin(2 * u) * Math.Log(2 * Math.Pow(y, 2) + Math.Sqrt(x));

            Console.WriteLine($"T = {T}");

        }
        public void Task23()
        {
            double G, e, y, f;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение f: ");
            f = Convert.ToDouble(Console.ReadLine());

            double Sum = 2 * y;

            e = 2.7;

            G = Math.Pow(e, Sum) + Math.Sin(f);

            Console.WriteLine($"G = {G}");

        }
        public void Task24()
        {
            double F, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            F = 2 + Math.Sin(0.214 * Math.Pow(y, 5) + 1);

            Console.WriteLine($"F = {F}");

        }
        public void Task25()
        {
            double G, e, y, f;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение f: ");
            f = Convert.ToDouble(Console.ReadLine());

            double Sum = 2 * y;

            e = 2.7;

            G = Math.Pow(e, Sum) + Math.Sin(Math.Pow(f, 2));

            Console.WriteLine($"G = {G}");

        }
        public void Task26()
        {
            double Z, p;

            Console.WriteLine("Введите значение p: ");
            p = Convert.ToDouble(Console.ReadLine());

            Z = Math.Pow(Math.Sin(Math.Pow(p, 2)), 3);

            Console.WriteLine($"Z = {Z}");
        }
        public void Task27()
        {
            double W, v, e, x, y;

            Console.WriteLine("Введите значение v: ");
            v = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            W = 1.03 * v + e * Math.Pow(e, 2 * y) + Math.Tan(x);

            Console.WriteLine($"W = {W}");
        }
        public void Task28()
        {
            double T, e, y, h;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение h: ");
            h = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            double sum = y * 6.4;

            T = Math.Pow(e, y + h) + Math.Sqrt(Math.Abs(sum));

            Console.WriteLine($"T = {T}");
        }
        public void Task29()
        {
            double N, y;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            N = 3 * Math.Pow(y, 2) + Math.Sqrt(Math.Abs(y + 1));

            Console.WriteLine($"N = {N}");
        }
        public void Task30()
        {
            double W, e, y, r;

            Console.WriteLine("Введите значение y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение r: ");
            r = Convert.ToDouble(Console.ReadLine());

            e = 2.7;

            W = Math.Pow(e, y + r) + 7.2 * Math.Sin(r);

            Console.WriteLine($"W = {W}");
        }

    }
}
