using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public DateTime DateofBirthder { get; set; } = DateTime.UtcNow;
        public string Gender { get; set; } = "Мужской";
        public char UserSelector { get; set; } = 'Y';
        public CheckUserWin PlayerChoice { get; set; } = CheckUserWin.Да;
        public enum CheckUserWin { Да = 1, Нет, };

        public Person() { }
        public Person(string name, DateTime dateofBirthder, string gender)
        {
            Name = name;
            DateofBirthder = dateofBirthder;
            Gender = gender;
        }
        private bool validateSelection()
        {

            char value = Char.ToUpper(UserSelector);
            if (value != 'S' && value != 'Z')

                return false;
            return true;
        }
        public bool validateRespomse(char responsE)
        {
            if (Char.ToUpper(responsE) != 'Y' && Char.ToUpper(responsE) != 'y')
                return true;
            return false;
        }
        private void Screen()
        {
            Console.WriteLine("S=Start");
            Console.WriteLine("Z- record");
            Console.WriteLine("n-");
            Console.WriteLine("Пожалуйста, сделайте свой выбор:");
        }

        public void Person2() { 
           //using(FileStream fs = new FileStream ("person1.xml" ,FileMode.));
           // { ReadState  PERSON =    ReadState.EndOfFile;

           //     Console.WriteLine(PERSON);
           //     Console.WriteLine();
           //     XmlWriter.Create("person1.xml");
           //     Console.WriteLine(Console.Out);

          
           // }
            Screen();
            UserSelector = Convert.ToChar(Console.ReadLine());

            if (UserSelector == 'S' || UserSelector == 'Z')
            {



                while (validateSelection())


                {

                    switch (Char.ToUpper(UserSelector))
                    {
                        case 'S':
                            Start();
                            break;
                        case 'Z':
                            Запись();
                            break;
                            Console.Clear();
                Console.WriteLine("До свидания");
                    }

                }
            }
            else
            {
                Console.WriteLine("До свидания");
            }

        }
        public void Запись()
        {
            
            char responseE;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("person1.xml" , FileMode.Open))
            {
                Person[] person2 = xmlSerializer.Deserialize(fs) as Person[];
                Console.WriteLine();
                Console.WriteLine("Файл из xml считывает ");

                if (person2 != null)
                {
                    foreach (Person tr in person2)
                    {
                        Console.WriteLine($"Name: {tr.Name}");
                        Console.WriteLine($"ADate of birth:{tr.DateofBirthder}");
                        Console.WriteLine($"Gender: {tr.Gender}");

                    }
                    XmlWriter.ReferenceEquals( Console.Out, Console.Out );

                }
            }
            Console.WriteLine(" Желайте ввести данные повторно сотрудника нажмите на y ");
            responseE = Convert.ToChar(Console.ReadLine());
            if (responseE == 'Y' || responseE == 'y')
            {
                Person2();
            }
            else
            {
                Console.Clear();
            }

        }
        //return  ;}
        public void Start()
        {

            Person[] person = new Person[]
            {
             new Person(),
             new Person(),
            };

            char responseE;
            
            //DirectoryInfo di = new DirectoryInfo("C:\\Users\\Максим\\source\\repos\\ConsoleApp2\\bin\\Debug\\person1.xml");
            //FileInfo[] TXTFiles = di.GetFiles("*.xml");
            //if (TXTFiles.Length == 0)
            //{
            //  Console.WriteLine("no files present");
            //}
            foreach (Person tr in person)
            {

                Console.Clear();

                Console.WriteLine("Ввидите имя");
                tr.Name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения в формате  (День.Месяц.Год):");

                tr.DateofBirthder = Convert.ToDateTime(Console.ReadLine());


                Console.WriteLine("Ввидите Пол : или ");

                Console.WriteLine("Мужской или Женский");
                tr.Gender = Console.ReadLine();
                if (tr.Gender == "Мужской" || tr.Gender == "Женский")
                {

                }
                else
                {
                    Console.WriteLine($"{tr.Gender} не выбран повторите снова");
                    tr.Gender = Console.ReadLine();

                }

            }
            try
            {

            }

            catch (Exception e) { 

            XmlSerializer xmlSerializer1 = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("person1.xml", mode: FileMode.OpenOrCreate))
            {
                xmlSerializer1.Serialize(fs, person);
                Console.WriteLine();
                Console.WriteLine("Файл из xml сохраняет ");
                if (person != null)
                {
                    foreach (Person tr in person)
                    {
                        Console.WriteLine($"Name: {tr.Name}");
                        Console.WriteLine($"Date of birth: {tr.DateofBirthder}");
                        Console.WriteLine($"Gender: {tr.Gender}");
                    }
                }
            }}
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("person1.xml", FileMode.Open))
            {
                Person person2 = xmlSerializer.Deserialize(fs) as Person;
                ReadState PERSON = ReadState.Error;
                Console.WriteLine(PERSON);
                Console.WriteLine("Файл из xml считывает ");

                foreach (Person tr1 in person)
                {
                    Console.WriteLine($"Name: {tr1.Name}");
                    Console.WriteLine($"date1.ToShortDateString()){tr1.DateofBirthder}");
                    Console.WriteLine($"Gender: {tr1.Gender}");
                }
            }
            Console.WriteLine(" Желайте ввести данные повторно сотрудника нажмите на y или n ");
            responseE = Convert.ToChar(Console.ReadLine());
            if (responseE == 'Y' || responseE == 'y')
            {
                Start();
            }
            else
            {
                Console.Clear();
                Person2();
            }

        }
    }
}
