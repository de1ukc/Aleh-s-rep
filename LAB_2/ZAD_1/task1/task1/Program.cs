using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using Microsoft.Win32;

namespace task1
{ 
    class Program
    {  static long binpow(long a, long n)
        {
            long res = 1;
            while (n > 0)
            {
                if (n % 2 == 1) res = res * a;
                a *= a;
                n /= 2;
            }
            return res;
        } 
        static long res(long a) { 
            long stepen = 0;
            if (a == 0) return 0;
            for (long i = 1; i < 64; i++)
              {
                stepen += a/binpow(2, i);
              }
            return stepen;
        }

        static void Main(string[] args)
        {   Console.WriteLine("Введите число a :");
            long a = int.Parse(Console.ReadLine());
           Console.WriteLine("Введите число b :");
            long b = int.Parse(Console.ReadLine());
            long ans = res(b) - res (a-1) ;
           Console.WriteLine(ans);
        }
    }
} 