using System;

namespace Lab_6_raznes
{
    public class Student : Human , ILabs 
    {
        protected int knowledge;// max 100 
        public string group;
        
        protected static int[] retaking = new int[10] ; // количество пересдач у всех студентов
            
        int counter = 0; // счётчик для пересдач

        public int getKnowlege()
        {
            return knowledge;
        }

        public static void Retek(Studentofspezialisation a)
        {
            if (a.knowledge < 20 && a.counter == 0)
            { 
                Console.WriteLine("you've missed to much lectures , you will have retaken");
                a[0] = 0;
                a[0]++;
                a.counter++;
            }
            else
            {
                if (a.knowledge < 20 && a.counter != 0)
                {
                    Console.WriteLine("you've missed to much lectures , you will have retaken");
                    a[0]++;
                    a.counter++;
                }
            }

            if (a[0] > 3)
            {
                Console.WriteLine("You're fired");
                Environment.Exit(0);
            }
        }
        
        public Student(int HP, int AP, int Power, int knowledge) : base(HP, AP, Power)
        {
            this.knowledge = knowledge;
        }
        
        public Student(int HP, int AP, int Power, int knowledge, string firstname, string secondname, string lastname, string group) : base(HP, AP, Power)
        {
            this.firstname = firstname;
            this.secondname = secondname;
            this.lastname = lastname;
            this.group = group;
        }
        
        
        public void Fuckingaround()
        {  Console.WriteLine("Well, your a typical student, and it' another day when you fucking around instead of classes , may be you are too bored");
            this.AP -= 2;
            if (this.AP <= 0)
            {
                this.AP = 0; 
                Console.WriteLine("Oh, you are to bord, you can't go to walk");
            }
            else
            {
                this.knowledge -= 6;
                if (this.knowledge < 0)
                {
                    this.knowledge = 0;
                    Console.WriteLine("I guess that you don't pass the session");
                }
            }
        }
        
        public virtual void Info() 
        { 
            Console.WriteLine($"Name : {firstname}");
            Console.WriteLine($"Secondname : {secondname}");
            Console.WriteLine($"Lastname : {lastname}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"HP: {HP}");
            Console.WriteLine($"AP: {AP}");
            Console.WriteLine($"Power: {power}");
            Console.WriteLine($"Knowledge: {this.knowledge}");
            Console.WriteLine($"group : {this.group}");
        }

        public virtual void Humor()
        {
        }

        public virtual void Nards()
        {
        }

        public void create_the_lab()
        {
        }

        public void pass_the_lab()
        {
        }
        
    }
}