using System;

namespace Lab_6_raznes
{
    public class Studentofspezialisation : Student , ILabs 
    {
        public string spezialisation;

        protected bool labsFlag = false;
        
        public Studentofspezialisation(int HP, int AP, int power, int knowledge) : base(HP, AP, power, knowledge)
        {
            this.knowledge = knowledge;
        }
        
        public Studentofspezialisation(int HP, int AP, int Power, int knowledge, string firstname, string secondname, string lastname) : base(HP, AP, Power,knowledge)
        {
            this.firstname = firstname;
            this.secondname = secondname;
            this.lastname = lastname;
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
        public void Info() 
        { Console.WriteLine($"Name : {firstname}");
            Console.WriteLine($"Secondname : {secondname}");
            Console.WriteLine($"Lastname : {lastname}");
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
            { Console.WriteLine("OOh , i'm too tired ");
            }
            else
            {
                Console.WriteLine("You've defeat a match in DOKA2 , now you are in rage");
                this.AP--;
            }
        }

        public void create_the_lab()
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

        public void pass_the_lab()
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
        
        public int Menu()
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
    }
}