using System;
using System.Collections.Generic;
namespace Lab_6_raznes
{
    public static class Entering
    {
        
        public static void entering ( Studentofspezialisation me) 
        {
            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your firstname : ");
            me.firstname = Console.ReadLine();
            while (Validation.Word(me.firstname) || me.firstname == "")
            {
                Console.WriteLine("You are liar.Enter your firstname correctly : ");
                me.firstname = Console.ReadLine();
            }

            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your secondname : ");
            me.secondname = Console.ReadLine();
            while (Validation.Word(me.secondname) || me.secondname == "")
            {
                Console.WriteLine("You are liar.Enter your secondname correctly : ");
                me.secondname = Console.ReadLine();
            }

            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your lastname : ");
            me.lastname = Console.ReadLine();
            while (Validation.Word(me.lastname) || me.lastname == "")
            {
                Console.WriteLine("You are liar.Enter your lastname correctly : ");
                me.lastname = Console.ReadLine();
            }

            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your Age : ");
            bool testage = Int32.TryParse(Console.ReadLine(), out me.age);
            //me.age = Int32.Parse(Number(Console.ReadLine()));
            while (me.age >= 120 || me.age < 17 || testage == false)
            {
                Console.WriteLine("I know that you've lide. Please enter your age :");
                //me.age = Int32.Parse(Number(Console.ReadLine()));
                testage = Int32.TryParse(Console.ReadLine(), out me.age);
            }

            //////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your group:");
            me.group = Console.ReadLine();
            while (me.@group == "")
            {
                Console.WriteLine("Please, write your group correctly:");
                me.group = Console.ReadLine();
            }

            //////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your spezialisation:");
            me.spezialisation = Console.ReadLine();
            while (Validation.Word(me.spezialisation) || me.spezialisation == "")
            {
                Console.WriteLine("You are liar.Enter your spezialisation correctly : ");
                me.spezialisation = Console.ReadLine();
            }
        }

        public static void work(Studentofspezialisation me)
        {
            me.Isalive();
            Student.Retek(me);
            switch (me.Menu())
            { 
                case (int)MyEnum.Sleep        : me.Sleep(8);       break;
                case (int)MyEnum.ShortSleep   : me.Sleep();           break;
                case (int)MyEnum.GYM          : me.GYM();             break;
                case (int)MyEnum.Doctor       : me.Doctor();          break;
                case (int)MyEnum.labCreate    : me.create_the_lab();  break;
                case (int)MyEnum.labPass      : me.pass_the_lab();    break; 
                case (int)MyEnum.MMA          : me.MMALection();      break;
                case (int)MyEnum.went         : me.Goingwent();       break; 
                case (int)MyEnum.Dota         : me.DOTA2();           break;
                case (int)MyEnum.skip_classes : me.Fuckingaround();   break;
                case (int)MyEnum.info         : me.Info();            break; 
                case (int)MyEnum.exit         : Console.WriteLine("GAME OVER");  Environment.Exit(0);break;
                default                       : Console.WriteLine("I swear to God, I do not know how you break this validation. " +
                                                                  "If it succeeded, it is not worth playing it, it is worth going to hackers."); break;

            }
        }
    }
}