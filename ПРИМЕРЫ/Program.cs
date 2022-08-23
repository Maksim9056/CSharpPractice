using System;

using System.IO;
using System.Xml.Linq;

namespace примеры1
{
    class Progman

    {
        public static void Main(Progman progman)
        {

            
            Progman progman = new Progman("Tom", "Microsoft");
            progman.Print();        // Tom работает в Microsoft
        }
    }

    class Person 
    {
     


        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public virtual void Print()
        {
            Console.WriteLine(Name);

            

        }
    
    

    }
        class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} работает в {Company}");
        }
    }

    


        }





















