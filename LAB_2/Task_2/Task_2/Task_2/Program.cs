using System;
using System.Linq;

namespace Task_2
{
    class A
    {
        public void cout()
        {
            Console.WriteLine("HUI");
        }
    }

    class B : A
    {
        public void cout()
        {
            Console.WriteLine("PIZDA");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        /*
            string[] bufer;
            bufer = Console.ReadLine().Split();
            Array.Reverse(bufer);
            for (int i = 0; i < bufer.Length; i++)
            {
                Console.Write(bufer[i] + " "); 
            }
            */
        B a = new B();
        a.cout();
        }
    }
}