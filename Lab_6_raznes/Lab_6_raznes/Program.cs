using System;
using System.Linq;

namespace Lab_6_raznes
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentofspezialisation me = new Studentofspezialisation(8,10,5, 70 );
            
            Entering.entering(me);

            while (true)
            {
                Entering.work(me);
            }
        }
    }
}