using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace personXml
{
    public class Person
    {
        public string Name { get; set; } = "Undefined";
        public string DateofBirth { get; set; } = "Дата";
        public string Gender { get; set; } = "Мужской";

        public Person() { }
        public Person(string name, string dateofBirthder, string gender)
        {
            Name = name;
          DateofBirth   = dateofBirthder;
            Gender = gender;
        }
        public bool validateRespomse(char responsE)
        {
            if (Char.ToUpper(responsE) != 'Y' && Char.ToUpper(responsE) != 'y')
                return true;
            return false;
        }
        public void Start()
        {

            Person[] person = new Person[]
            {
                new Person(),
                /*new Person(),
                new Person(),
                new Person(),
                new Person(),
                new Person(),
                new Person(),
                new Person(),
                new Person(),*/
                new Person()
            };

            char responseE;
            
            foreach (Person tr in person)
            {
               
            Console.Clear();

            Console.WriteLine("Ввидите имя");
            tr.Name = Console.ReadLine();
                Console.WriteLine("Введите дату рождения в формате  (День.Месяц.Год):");

                tr.DateofBirth = Console.ReadLine();
            Console.WriteLine("Ввидите Пол : или ");

            Console.WriteLine("Мужской или Женский");
            tr.Gender = Console.ReadLine();
            if (tr.Gender == "Мужской" || tr.Gender == "Женский")
            {
               // Console.WriteLine($"Пол:{tr.Gender}");
            }
            else
            {
                Console.WriteLine($"{tr.Gender} не выбран повторите снова");
               tr.Gender = Console.ReadLine();
                    
                }
             
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person[]));
            using (FileStream fs = new FileStream("person.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, person);
                Console.WriteLine();
                Console.WriteLine("Файл из xml сохраняет ");
                if (person != null)
                {
                    foreach (Person tr in person)
                    {
                        Console.WriteLine($"Name: {tr.Name}");
                        Console.WriteLine($"Age: {tr.DateofBirth}");
                        Console.WriteLine($"Gender: {tr.Gender}");
                    }
                }
            }
            using (FileStream fs = new FileStream("person.xml", FileMode.Open))
            {
                Person[]? person2 = xmlSerializer.Deserialize(fs) as Person[];
                Console.WriteLine();
                Console.WriteLine("Файл из xml считывает ");
       
                if (person2 != null)
                {
                    foreach (Person tr in person2)
                    {
                        Console.WriteLine($"Name: {tr.Name}");
                        Console.WriteLine($"Age: {tr.DateofBirth}");
                        Console.WriteLine($"Gender: {tr.Gender}");
                    }
                }
            }
                    Console.WriteLine(" Желайте ввести данные повторно сотрудника нажмите на y ");
                    responseE = Convert.ToChar(Console.ReadLine());
                    if (responseE == 'Y' || responseE == 'y')
                    {
                       person[1].Start();
                    }
                    else
                    {
                        Console.Clear();
                    }
               

            }
        }
 }

