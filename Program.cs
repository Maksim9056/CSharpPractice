﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var person = new Person();


            char responseE;

            Console.WriteLine("Ввидите данные сотрудника (y или n)?");
            responseE = Convert.ToChar(Console.ReadLine());

            if (responseE == 'Y' || responseE == 'y')
            {
                person.Person2();
            }
            else
            {
                Console.WriteLine("Неправильный ввод символ Y.Повторите попытку вести даные  сотрудника y  ");
                responseE = Convert.ToChar(Console.ReadLine());
                person.Person2();
            }
            Console.WriteLine("До свидания");
        }
    }
    }

