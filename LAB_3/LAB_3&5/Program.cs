using System;
using System.Linq;

namespace MyStudents
{
    enum MyEnum 
    { Sleep = 1,
        ShortSleep ,
        GYM ,
        Doctor ,
        Dota ,
        skil_classes ,
        MMA ,
        went ,
        info ,
        exit = 0
    }
    class Human
    {
        protected int HP;//очки здоровья
        protected int AP;//очки действия 
        protected int Power;//очки силы
        public string firstname;
        public string secondname;
        public string lastname;
        public int age;
        public Human(int HP, int AP, int Power)
        {
            this.HP = HP;
            this.AP= AP;
            this.Power = Power;
        }

       public void info()
       { Console.WriteLine($"Name : {firstname}");
         Console.WriteLine($"Secondname : {secondname}");
         Console.WriteLine($"Lastname : {lastname}");
         Console.WriteLine($"Age : {age}");
         Console.WriteLine($"HP: {HP}");
         Console.WriteLine($"AP: {AP}");
         Console.WriteLine($"Power: {Power}");
        }

       public void isalive()
       {
                if (this.HP == 0)
                {Console.WriteLine("YOU DIE"); Environment.Exit(0); }
       }

       public int Menu()
       { Console.WriteLine("\n");
           Console.WriteLine("Well, we can do some shit, what are we gonna do?");
       Console.WriteLine("1.Get some sleep");
       Console.WriteLine("2.Get some sleep , but during the day ( VERY DANGEROUS!!!)");
       Console.WriteLine("3.Go to the GYM to your Dungeon Master");
       Console.WriteLine("4.Go to the doctor");
       Console.WriteLine("5.Games");
       Console.WriteLine("6.You can fucking aroud somewhere");
       Console.WriteLine("7.You can visit MMA lecture");
       Console.WriteLine("8.You can go went ");
       Console.WriteLine("9.Info");
       Console.WriteLine("0.I want to finish this stupid life.");
       Console.WriteLine("Enter your choice as a number please");
       int i = Int32.Parse(Program.Number(Console.ReadLine()));
       while (i > 9 || i < 0)
       { Console.WriteLine("I know that you've lide. Please enter again :");
           i = Int32.Parse(Program.Number(Console.ReadLine()));
       }
       Console.WriteLine("\n");
       return i;
       }

       public void Sleep(int a) // += 4
       {
           this.AP += 4;
           if (this.AP >= 10) { this.AP = 10;}
       Console.WriteLine($"You've been asleep all night,{a} hours.Your AP now is {this.AP}");
       }

       public void Sleep() // rand
       {
           var random = new Random();
           int a = random.Next(1, 6);
           this.AP += a;
           if (this.AP > 10) { this.AP = 10; }
           Console.WriteLine("You went to bed in the afternoon, it is not known at what time of the year and era you woke up." +
                          $" It seems better not to do so. Your AP has increased to {this.AP} points.");
           
       }
       public void GYM()
       {
           if (this.HP <= 5)
           { Console.WriteLine("I'm sick, I need to heal first before I go to the GUM bosses");
           }
           else
           {
               if (this.AP < 4)
               {
                   Console.WriteLine("Oh no, i'm too tired.");
               }

               if (this.AP > 4 && this.AP < 10)
               {
                   this.Power++;
                   this.AP -= 2;
                   if (this.Power > 10)
                   {
                       this.Power = 10;
                       Console.WriteLine("Wow , you are dungen master.");
                   }

                   Console.WriteLine(
                       $"You found Master of the GYM and worked out.Your Power now is increased to {this.Power}");
               }
               if (this.AP == 10)
               {
                   this.AP -= 3;
                   this.Power += 2;
                   if (this.Power > 10)
                   {
                       this.Power = 10;
                   }

                   Console.WriteLine($"UNLIMITED POWEEER.\n Your Power now is increased to {this.Power}");
               }
               Random oh = new Random();
               int a = oh.Next(100);
               if (a == 100)
               {
                   this.HP--;
                   Console.WriteLine($"you are injured, you should go to the doctor, your HP is now equal {this.HP}");
               }
               if (this.Power == 10)
               {Console.WriteLine("I'm too strong and powerful , now i can everything.");
               }
           }
       }
       public void Doctor()
       {
           if (this.HP == 10)
           { Console.WriteLine("you are healthy, you do not need treatment");
           }

           if (this.HP != 10)
           {
               this.HP += 3;
               if (this.HP > 10)
               { this.HP = 10;}
               Console.WriteLine($"you were cured, you HP : {this.HP}");
           }
           Random woops = new Random();
           int b = woops.Next(50);
           if (b == 27 )
           { this.HP -= 4;
               if (this.HP <= 0)
               {
                   this.HP = 0; Console.WriteLine("YOU DIE"); Environment.Exit(0); 

               }
               Console.WriteLine($"Woops you got even more ill in the hospital, your HP : {this.HP}");
               
           }
       }

       public void Work()
       {  if (this.HP<5){Console.WriteLine("Oh no, i'm sick , it's better stay home");}
           else
           { Console.WriteLine("Well, you've decided to go to work. Another boring day .");
               this.AP -= 2;
           }
       }
       public void goingwent()
       {
           if (this.HP < 5)
           {Console.WriteLine("It's better stay home. I'm sick");
           }
           else
           {
               if (this.AP < 3)
               {Console.WriteLine("I'm too tired for that, better go home and drink something");
               }
               else
               { Console.WriteLine("I love to walk , the city is wonderful");
                   this.HP++;
                   if (this.HP > 10) { this.HP = 10;}
                   this.AP--;
                   if (this.AP <= 0)
                   {
                       this.AP = 0;
                   }
               }
           }
       }
    }
    class Student : Human
    {
        protected int knowledge;// max 100 
        protected static int retaking = 0 ; // количество пересдач у всех студентов

        public static void retek(Student a)
        {
            if (a.knowledge < 20)
            { Console.WriteLine("you've missed to much lectures , you will have retaken");
                retaking++;
            }
        }

        public Student(int HP, int AP, int Power, int knowledge) : base(HP, AP, Power)
        {
            this.knowledge= knowledge;
        }
        public string group;
        public void fuckingaround()
        {  Console.WriteLine("Well, your a typical student, and it' another day when you fucking around instead of classes , may be you are too bored");
            this.AP -= 2;
            if (this.AP <= 0)
            {
                this.AP = 0; 
                Console.WriteLine("Oh, you are to bord, you can't go to walk");
            }
            else
            {
                this.knowledge -= 4;
                if (this.knowledge < 0)
                {
                    this.knowledge = 0;
                    Console.WriteLine("I guess that you don't pass the session");
                }
            }
        }
        public void info() 
        { Console.WriteLine($"Name : {firstname}");
            Console.WriteLine($"Secondname : {secondname}");
            Console.WriteLine($"Lastname : {lastname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"AP: {AP}");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Knowledge: {this.knowledge}");
            Console.WriteLine($"group : {this.group}");
        }
    }

    class Studentofspezialisation : Student
    {
        public string Spezialisation;
        public Studentofspezialisation(int HP, int AP, int Power, int knowledge) : base(HP, AP, Power, knowledge)
        {
            this.knowledge = knowledge;
        }
        public void MMALection()
        {
            if (this.AP < 4 )
            { Console.WriteLine("it is useless , i'm too tired for that shit. Better stay home.");
            }
            else
            {
                this.AP -= 2;
                Console.WriteLine(
                    "Congratulations, you attended the lecture on MMA and you were not even crossed out by Anisimov," +
                    " i hope you at least understood something ");
                this.knowledge += 2;
                if (this.knowledge > 100)
                {
                    this.knowledge = 100;
                }
            }
        }
        public void info() 
        { Console.WriteLine($"Name : {firstname}");
            Console.WriteLine($"Secondname : {secondname}");
            Console.WriteLine($"Lastname : {lastname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"AP: {AP}");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Knowledge: {this.knowledge}");
            Console.WriteLine($"group : {this.group}");
            Console.WriteLine($"Spezialisation : {this.Spezialisation}");
        }
        public void DOTA2()
        {   
            if (this.AP < 2)
            { Console.WriteLine("OOh , i'm too tired ");
            }
            else
            {
                Console.WriteLine("You've defeat a match in DOKA2 , now you are in rage");
                this.AP--;
            }
        }
    }
    class Program
    {   public static bool Word(string item)
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
            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your firstname : ");
            me.firstname = Console.ReadLine();
            while (Word(me.firstname) || me.firstname == "")
            { Console.WriteLine("You are liar.Enter your firstname correctly : ");
                me.firstname = Console.ReadLine();
            }
            //////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your secondname : ");
            me.secondname = Console.ReadLine();
            while (Word(me.secondname) || me.secondname == "")
            { Console.WriteLine("You are liar.Enter your secondname correctly : ");
                me.secondname = Console.ReadLine();
            }
            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your lastname : ");
            me.lastname = Console.ReadLine();
            while (Word(me.lastname) || me.lastname == "")
            { Console.WriteLine("You are liar.Enter your lastname correctly : ");
                me.lastname = Console.ReadLine();
            }
            ////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your Age : ");
            bool testage = Int32.TryParse(Console.ReadLine(),out me.age);
            //me.age = Int32.Parse(Number(Console.ReadLine()));
            while (me.age >= 120 || me.age < 17 || testage == false )
            { Console.WriteLine("I know that you've lide. Please enter your age :");
                //me.age = Int32.Parse(Number(Console.ReadLine()));
                 testage = Int32.TryParse(Console.ReadLine(), out me.age);
            }
            //////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your group:");
            me.group = Console.ReadLine();
            while (me.@group == "")
            {Console.WriteLine("Please, write your group correctly:");
                me.group = Console.ReadLine();
            }

            //////////////////////////////////////////////////////////////////
            Console.WriteLine("Enter your spezialisation:");
            me.Spezialisation= Console.ReadLine();
            while (Word(me.Spezialisation) || me.Spezialisation == "")
            { Console.WriteLine("You are liar.Enter your spezialisation correctly : ");
                me.Spezialisation = Console.ReadLine();
            }
            //////////////////////////////////////////////////////////////////
            while (true)
            { me.isalive();
                Student.retek(me);
                switch (me.Menu())
                { case (int)MyEnum.Sleep        : me.Sleep(8); break;
                  case (int)MyEnum.ShortSleep   : me.Sleep(); break;
                  case (int)MyEnum.GYM          : me.GYM(); break;
                  case (int)MyEnum.Doctor       : me.Doctor(); break;
                  case (int)MyEnum.Dota         : me.DOTA2();break;
                  case (int)MyEnum.skil_classes : me.fuckingaround();break;
                  case (int)MyEnum.MMA          : me.MMALection();break;
                  case (int)MyEnum.went         : me.goingwent();break;
                  case (int)MyEnum.info         : me.info(); break;
                  case (int)MyEnum.exit         : Console.WriteLine("GAME OVER");  Environment.Exit(0);break;
                  default                  : Console.WriteLine("I swear to God, I do not know how you break this validation. " +
                                             "If it succeeded, it is not worth playing it, it is worth going to hackers."); break;

                }
            }
        }
    }
}
