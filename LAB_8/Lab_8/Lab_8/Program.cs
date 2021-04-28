using System;

namespace Lab_8
{

    class Program
    {
        
        static void Main(string[] args)
        {
            Studentofspezialisation st = new Studentofspezialisation(6,8,4,40,"Nikolas","Vashkevich","Vladimirovich", "053502"); 
            Student hm = new Studentofspezialisation(5,7,6,40,"Dmitry","Gotchenya","Gennad'evich ","053502");    
            
            st.PrintSomething(x  =>
             {
                 
                 Console.WriteLine("You can write here whatever you want:" );
                 x = Console.ReadLine();
                 Console.WriteLine(x);
             });
            
            st.Cleverer += msg => Console.WriteLine(msg);
            st.Stupider += delegate(string msg) { Console.WriteLine(msg); };
            st.Equal += msg => Console.WriteLine(msg);
            st.BrainTest(st,hm,"Nikolas");
        }
    }
}