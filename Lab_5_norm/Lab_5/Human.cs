using System;
using System.Linq;


namespace Lab_6_raznes
{    
    
    public class Human
    {
        protected int HP;//очки здоровья
        protected int AP;//очки действия 
        protected int power;//очки силы
        public string firstname;
        public string secondname;
        public string lastname;
        public int age;
        public Human(int HP, int AP, int power)
        {
            this.HP = HP;
            this.AP= AP;
            this.power = power;
        }

        public void Info()
       { 
         Console.WriteLine($"Name : {firstname}");
         Console.WriteLine($"Secondname : {secondname}");
         Console.WriteLine($"Lastname : {lastname}");
         Console.WriteLine($"Age : {age}");
         Console.WriteLine($"HP: {HP}");
         Console.WriteLine($"AP: {AP}");
         Console.WriteLine($"Power: {power}");
        }

        public void Isalive()
       {
                if (this.HP == 0)
                {Console.WriteLine("YOU DIED"); Environment.Exit(0); }
       }

       public virtual int Menu()
       { 
       Console.WriteLine("\n"); Console.WriteLine("Well, we can do some shit, what are we gonna do?");
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
       int i = Int32.Parse(Validation.Number(Console.ReadLine()));
       while (i > 9 || i < 0)
       { 
           Console.WriteLine("I know that you've lide. Please enter again :");
           i = Int32.Parse(Validation.Number(Console.ReadLine()));
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
           if (this.AP > 10)
           {
               this.AP = 10;
           }

           Console.WriteLine(
               "You went to bed in the afternoon, it is not known at what time of the year and era you woke up." +
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
                   this.power++;
                   this.AP -= 2;
                   if (this.power > 10)
                   {
                       this.power = 10;
                       Console.WriteLine("Wow , you are dungen master.");
                   }

                   Console.WriteLine(
                       $"You found Master of the GYM and worked out.Your Power now is increased to {this.power}");
               }
               if (this.AP == 10)
               {
                   this.AP -= 3;
                   this.power += 2;
                   if (this.power > 10)
                   {
                       this.power = 10;
                   }

                   Console.WriteLine($"UNLIMITED POWEEER.\n Your Power now is increased to {this.power}");
               }
               Random oh = new Random();
               int a = oh.Next(100);
               if (a == 100)
               {
                   this.HP--;
                   Console.WriteLine($"you are injured, you should go to the doctor, your HP is now equal {this.HP}");
               }
               if (this.power == 10)
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
       
       public void Goingwent()
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
    
}