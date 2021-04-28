using System;
using System.Drawing.Printing;

namespace Lab_8
{
     public class Studentofspezialisation : Student , ILabs , Comp<Studentofspezialisation, Student> , IGames
     {
         public delegate void PrintMethod(string msg);
         
         public void PrintSomething(PrintMethod method)
         {
             method?.Invoke(ToString());
         }
         
        public delegate void Greatmind(string msg); 
        public event Greatmind Cleverer;
        public event Greatmind Stupider;
        public event Greatmind Equal;

        public void BrainTest(Studentofspezialisation a, Student b , string name ) // must change text 
        {
            int i = Comparator(a, b);
            switch (i)
            {
                case  1  : Cleverer?.Invoke($"Yes , science bitch, {name} smarter"); break;
                case -1  : Stupider?.Invoke($"Wooops,  {name} are stupider"); break;
                case  0  : Equal?.Invoke("We both are genius"); break;
                default  : Console.WriteLine("I guess there was a mistake"); break;
            }
        }
        
        public string spezialisation;

        protected bool labsFlag = false;
        
        public Studentofspezialisation(int HP, int AP, int power, int knowledge) : base(HP, AP, power, knowledge)
        {
            this.knowledge = knowledge;
        }
        
        public Studentofspezialisation(int HP, int AP, int Power, int knowledge, string firstname, string secondname, string lastname, string group) : base(HP, AP, Power,knowledge)
        {
            this.firstName  = firstname;
            this.secondName = secondname;
            this.lastName   = lastname;
            this.group      = group;
        }

        public virtual void MMALection()
        {
            if (this.AP < 4 )
            { 
                Console.WriteLine("it is useless , i'm too tired for that shit. Better stay home.");
            }
            else
            {
                this.AP -= 2;
                Console.WriteLine("Congratulations, you attended the lecture on MMA and you were not even crossed out by Anisimov," +
                                  " i hope you at least understood something ");
                this.knowledge += 2;
                if (this.knowledge > 100)
                {
                    this.knowledge = 100;
                }
            }
        }
        
        public override void Info ()
        { 
            Console.WriteLine($"Name : {firstName}");
            Console.WriteLine($"Secondname : {secondName}");
            Console.WriteLine($"Lastname : {lastName}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"AP: {AP}");
            Console.WriteLine($"Power: {power}");
            Console.WriteLine($"Knowledge: {this.knowledge}");
            Console.WriteLine($"group : {this.group}");
            Console.WriteLine($"Spezialisation : {this.spezialisation}");
        }

        public int this[int index]
        {
            get { return retaking[index]; }
            set { retaking[index] = value;}
        }

        public void DOTA2()
        {   
            if (this.AP < 2)
            { 
                Console.WriteLine("OOh , i'm too tired ");
            }
            else
            {
                Console.WriteLine("You've defeat a match in DOKA2 , now you are in rage");
                this.AP--;
            }
        }

        public void CreateTheLab()
        {
            if (labsFlag == true )
            {
                Console.WriteLine("You've alredy did one lab. Pass this lab first and only then create another");
            }
            else
            {
                Console.WriteLine("Ok.So you did a C++ lab. Thats great BUT you need to pass this lab and int not that easy. So go ahead.");
                labsFlag = true;
            }
        }

        public void PassTheLab()
        {
            Random r = new Random();
            int a = r.Next(2);
            if (labsFlag == false)
            {
                Console.WriteLine("Heeey, you need a lab befor you will pass her. So DO IT!");
            }
            else
            {
                if (a == 0) Console.WriteLine("Ooooh. You didn't pass this lab . Better luck next time");
                if (a == 1)
                {
                    Console.WriteLine("Well, well.You pass this lab. Exelent");
                    labsFlag = false;
                }
            }
        }

        public int Comparator(Studentofspezialisation a, Student b )
        {
            if (a.getKnowlege() > b.getKnowlege())  return 1;
            if (a.getKnowlege() < b.getKnowlege())  return -1;
            if (a.getKnowlege() == b.getKnowlege()) return 0;
            return 2;
        }

        public override int Menu()
        {
            Console.WriteLine("\n"); Console.WriteLine("Well, we can do some shit, what are we gonna do?");
            Console.WriteLine("1.Get some sleep");
            Console.WriteLine("2.Get some sleep , but during the day ( VERY DANGEROUS!!!)");
            Console.WriteLine("3.Go to the GYM to your Dungeon Master");
            Console.WriteLine("4.Go to the doctor");
            Console.WriteLine("5.Create the lab");
            Console.WriteLine("6.Pass the lab");
            Console.WriteLine("7.You can visit MMA lecture");
            Console.WriteLine("8.You can go went ");
            Console.WriteLine("9.You can play Dota 2");
            Console.WriteLine("10.You can skip classes and fucking around");
            Console.WriteLine("11.Info");
            Console.WriteLine("0.I want to finish this stupid life.");
            Console.WriteLine("Enter your choice as a number please");
            int i;
            bool test = Int32.TryParse(Console.ReadLine(), out i);
            while (i > 11 || i < 0 || test == false)
            {
                Console.WriteLine("I know that you've lide. Please enter your choice correctly:");
                test = Int32.TryParse(Console.ReadLine(), out i);
            }
            Console.WriteLine("\n");
            return i;
        }

        public void RussianRoulette()
        {
            Console.WriteLine("Okay , here we go , we are students of IITP, we are fearless and we play in hard games.");
            Console.WriteLine("So, we gonna play Russian Roulette");
            Console.WriteLine("We charge 1 bullet");
            Random r = new Random();
            int yourPick;
            int bullet = r.Next(7);    
            int[] drum = new int [6]; 
            drum[bullet] = 1; 
            while (true)
            {
                Console.WriteLine("Enter a number between 0 and 5 , 6 == Exit ");
                bool test = Int32.TryParse(Console.ReadLine(), out yourPick);
                while (yourPick > 6 || yourPick < 0 || test == false)
                {
                    Console.WriteLine("I know that you've lide. Please enter your age :");
                    test = Int32.TryParse(Console.ReadLine(), out yourPick);
                }
                if (yourPick == 6) return;
                else if (drum[bullet] == drum[yourPick])
                {
                    Console.WriteLine("YOU DIE");
                    Environment.Exit(0);
                }
                else Console.WriteLine("I have won , Jessy");
            }
        }

        public void Cards()
        {
            Console.WriteLine("We dont play this  game, we play only hardgames , only hardkore");
        }
     }
}