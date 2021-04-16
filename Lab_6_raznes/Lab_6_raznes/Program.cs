using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab_6_raznes
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentofspezialisation me = new Studentofspezialisation(8,10,5, 70 );
            
            Entering.entering(me);
            
            Student st = new Studentofspezialisation(6,8,4,50,"Nikolas","Vashkevich","Vladimirovich","053506"); 
            
            me.BrainTest(me,st); // compare intefrace
            
            Human a = new Human("Aleh",17);
            
            Human b = new Human("Artem",19);
            
            Human c = new Human("Kolya",18);
            
            List<Human> people = new List<Human>(){a,b,c};
            
            people.Sort(); // my own  IComparable
    
            foreach(Human humn in people)
            {
                Console.WriteLine(humn.firstname);
            }
            
            IGames saw = new Studentofspezialisation(5,7,6,40,"Dmitry","Gotchenya","Gennad'evich ","053506");
            saw.russianRoulette();
        }
    }
}