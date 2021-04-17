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
            me.firstName = Console.ReadLine();
            while (Validation.Word(me.firstName) || me.firstName == "")
            {
                Console.WriteLine("You are liar.Enter your firstname correctly : ");
                me.firstName = Console.ReadLine();
            }
            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your secondname : ");
            me.secondName = Console.ReadLine();
            while (Validation.Word(me.secondName) || me.secondName == "")
            {
                Console.WriteLine("You are liar.Enter your secondname correctly : ");
                me.secondName = Console.ReadLine();
            }
            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your lastname : ");
            me.secondName = Console.ReadLine();
            while (Validation.Word(me.secondName) || me.secondName == "")
            {
                Console.WriteLine("You are liar.Enter your lastname correctly : ");
                me.secondName = Console.ReadLine();
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
                case (int)MyEnum.labCreate    : me.CreateTheLab();  break;
                case (int)MyEnum.labPass      : me.PassTheLab();    break; 
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