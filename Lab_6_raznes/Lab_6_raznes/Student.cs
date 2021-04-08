using System;

namespace Lab_6_raznes
{
    public class Student : Human
    {
        protected int knowledge;// max 100 
        protected static int[] retaking = new int[10] ; // количество пересдач у всех студентов

        public static void Retek(Studentofspezialisation a)
        {
            if (a.knowledge < 20)
            { 
                Console.WriteLine("you've missed to much lectures , you will have retaken");
                a[0] = 0;
                a[0]++;

            }
        }
        
        public Student(int HP, int AP, int Power, int knowledge) : base(HP, AP, Power)
        {
            this.knowledge = knowledge;
        }
        
        public string group;
        
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
                this.knowledge -= 4;
                if (this.knowledge < 0)
                {
                    this.knowledge = 0;
                    Console.WriteLine("I guess that you don't pass the session");
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
        }
    }
}