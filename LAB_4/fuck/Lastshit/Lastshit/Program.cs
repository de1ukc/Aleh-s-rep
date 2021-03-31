using System;
using System.Runtime.InteropServices;

namespace Lastshit
{
    static class Calculation
    {
        [DllImport("mathstuff.dll",  CallingConvention = CallingConvention.StdCall)]
        public static extern int Sum(int a, int b);

        [DllImport("mathstuff.dll",  CallingConvention = CallingConvention.StdCall)]
        public static extern int  Multiply(int a, int b);
        
        [DllImport("mathstuff.dll",  CallingConvention = CallingConvention.StdCall)]
        public static extern int  Divide(int a, int b);
        
        [DllImport("mathstuff.dll",  CallingConvention = CallingConvention.StdCall)]
        public static extern int  Pow(int a, int b);
        
        [DllImport("mathstuff.dll",  CallingConvention = CallingConvention.StdCall)]
        public static extern int  Mod(int a, int b);

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! This program can do some math shit with integer numbers.But this is my project and I won't allow it " +
                              " , you can only watch)))");
            int a = 21;
            int b = 7;
            Console.WriteLine($"a = {a} , b = {b} ");
            Console.WriteLine($"a + b = {Calculation.Sum(a, b)}");
            Console.WriteLine($"a * b = {Calculation.Multiply(a, b)}");
            Console.WriteLine($"a / b = {Calculation.Divide(a, b)}");
            Console.WriteLine($"a ^ b = {Calculation.Pow(a, b)}");
            Console.WriteLine($"a % b = {Calculation.Mod(a, b)}");
            
        }
    }
}