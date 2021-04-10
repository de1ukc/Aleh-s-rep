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
            Console.WriteLine("\n");
            me.Info();
            
            Student st = new Studentofspezialisation(6,8,4,50,"Nikolas","Vashkevich",""); 
            Console.WriteLine("\n");
            st.Info();
            
            Human hm = new Student(5,7,6,40,"Dmitry","Gotchenya"," ");
            Console.WriteLine("\n");
            hm.Info();
            
        }
    }
}