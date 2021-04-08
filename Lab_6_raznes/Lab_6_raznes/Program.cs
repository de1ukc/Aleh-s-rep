using System;
using System.Linq;

namespace Lab_6_raznes
{
    class Program
    {
        public static bool Word(string item)
        {
            if (item.All(i => ((i >= 'A' && i <= 'Z') || (i >= 'a' && i <= 'z')))) return false;
            return true;
        }
        
        public static string Number(string item)
        {
            if (item.All(i => i <= '9' && i >= '.' && i != '/')) return item;
            return "0";
        }
        
        static void Main(string[] args)
        {
            Studentofspezialisation me = new Studentofspezialisation(8,10,5, 70 );
            
            Entering.entering(me);
            
            while (true)
            { me.Isalive();
                Student.Retek(me);
                switch (me.Menu())
                { case (int)MyEnum.Sleep        : me.Sleep(8); break;
                  case (int)MyEnum.ShortSleep   : me.Sleep(); break;
                  case (int)MyEnum.GYM          : me.GYM(); break;
                  case (int)MyEnum.Doctor       : me.Doctor(); break;
                  case (int)MyEnum.labCreate    : me.create_the_lab();break;
                  case (int)MyEnum.labPass      : me.pass_the_lab();break; 
                  case (int)MyEnum.MMA          : me.MMALection();break;
                  case (int)MyEnum.went         : me.Goingwent();break; 
                  case (int)MyEnum.info         : me.Info(); break; 
                  case (int)MyEnum.exit         : Console.WriteLine("GAME OVER");  Environment.Exit(0);break;
                  default                       : Console.WriteLine("I swear to God, I do not know how you break this validation. " +
                                             "If it succeeded, it is not worth playing it, it is worth going to hackers."); break;

                }
            }
        }
    }
}