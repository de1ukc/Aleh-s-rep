using System;

namespace Lab_8
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Studentofspezialisation iitp = new Studentofspezialisation(6,8,4,60,"Nikolas","Vashkevich","Vladimirovich", "053502"); 
            Student st = new Studentofspezialisation(5,7,6,40,"Dmitry","Gotchenya","Gennad'evich ","053502");    
            Human hm = new Studentofspezialisation(8,4,7,75,"Aleh","Asadchy","eduardovich", "053506");
            
            iitp.Feedback(x  =>
             {
                 Console.WriteLine("You can write here whatever you want:" );
                 x = Console.ReadLine();
                 Console.WriteLine(x);
             });
            
            iitp.Cleverer += msg => Console.WriteLine(msg);
            iitp.Stupider += delegate(string msg) { Console.WriteLine(msg); };
            iitp.Equal += msg => Console.WriteLine(msg);
            iitp.BrainTest(iitp,st,"Nikolas");

            void Shclaffen(int hr)
            {
                Console.WriteLine($"I slept for {hr} hours");
            }
            
            hm.Slumber += Shclaffen;
            hm.Sleep(5);
            

        }
    }
}