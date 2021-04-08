using System;

namespace Lab_6_raznes
{
    public static class Entering
    {
        public static void entering(Studentofspezialisation me)
        {
            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your firstname : ");
            me.firstname = Console.ReadLine();
            while (Program.Word(me.firstname) || me.firstname == "")
            {
                Console.WriteLine("You are liar.Enter your firstname correctly : ");
                me.firstname = Console.ReadLine();
            }

            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your secondname : ");
            me.secondname = Console.ReadLine();
            while (Program.Word(me.secondname) || me.secondname == "")
            {
                Console.WriteLine("You are liar.Enter your secondname correctly : ");
                me.secondname = Console.ReadLine();
            }

            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your lastname : ");
            me.lastname = Console.ReadLine();
            while (Program.Word(me.lastname) || me.lastname == "")
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
            while (Program.Word(me.spezialisation) || me.spezialisation == "")
            {
                Console.WriteLine("You are liar.Enter your spezialisation correctly : ");
                me.spezialisation = Console.ReadLine();
            }

            //////////////////////////////////////////////////////////////////
        }
    }
}