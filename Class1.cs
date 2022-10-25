using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Пробник
{
    internal class Class1
    {
        public enum CheckUserWin { Камень = 1, Бумага, Ножницы };
        public enum Outcome  { Победа, Проиграл, Ничья };
        public CheckUserWin СomputerChoice { get; set; }
        public CheckUserWin PlayerChoice { get; set; }
        public char UserSelector { get; set; }

        public CheckUserWin getUserHand()
        {
            while (!validateSelection())

                Console.WriteLine("Неправильный ввод");
            Screen();

            UserSelector = Convert.ToChar(Console.ReadLine());
            {

                switch (Char.ToUpper(UserSelector))
                {
                    case 'R':
                        PlayerChoice = CheckUserWin.Камень;
                        break;
                    case 'P':
                        PlayerChoice = CheckUserWin.Бумага;
                        break;
                    case 'S':
                        PlayerChoice = CheckUserWin.Ножницы;
                        break;
                    default:
                        throw new Exception("Непредвиденная ошибка");
                }
                return PlayerChoice;
            }
        }
        public void PlayGame()
        {
            bool gameOver = false;
            var rand = new Random();
            char responsE; 
            
            while (!gameOver)
            {
                Screen();

                UserSelector = Convert.ToChar(Console.ReadLine());
                getUserHand();   
                СomputerChoice = (CheckUserWin)rand.Next(1, 4);            
                Screen();
               
                Console.Clear();
                Console.WriteLine("Выбор компьютера{0}", СomputerChoice);
                Console.WriteLine("Выбор игрока {0}", PlayerChoice);
                if (DetermineWiner() == Outcome.Победа)
                    Console.WriteLine("{0} битва {1}. Игрок выигрывает", PlayerChoice, СomputerChoice);
                else if (DetermineWiner() == Outcome.Проиграл)

                    Console.WriteLine("{0} битва {1}. Компьютер выигрывает", СomputerChoice, PlayerChoice);

                else
                    Console.WriteLine("это ничья");

                Console.WriteLine("\nХотели бы вы сыграть в другую игру (y или n)");
                responsE = Convert.ToChar(Console.ReadLine());
                while (validateRespomse(responsE) == false)
                {
                    Console.WriteLine("Неверный ввод.Пожалуйста, повторно введите свой выбор:");
                    responsE = Convert.ToChar(Console.ReadLine());
                }
                {
                    if (responsE == 'N' || responsE == 'n')
                        gameOver = true;
                    Console.Clear();
                }
            }
        }
       
        public Outcome DetermineWiner()
        {

            if (PlayerChoice == CheckUserWin.Ножницы && СomputerChoice == CheckUserWin.Бумага)
                return Outcome.Победа;
            else if (PlayerChoice == CheckUserWin.Камень && СomputerChoice == CheckUserWin.Ножницы)
                return Outcome.Победа;
            else if (PlayerChoice == CheckUserWin.Бумага && СomputerChoice == CheckUserWin.Камень)
                return Outcome.Победа;
            else if (PlayerChoice == CheckUserWin.Ножницы && СomputerChoice == CheckUserWin.Камень)
                return Outcome.Проиграл;
            else if (PlayerChoice == CheckUserWin.Камень && СomputerChoice == CheckUserWin.Бумага)
                return Outcome.Проиграл;
            else if (PlayerChoice == CheckUserWin.Бумага && СomputerChoice == CheckUserWin.Ножницы)
                return Outcome.Проиграл;
            return Outcome.Ничья;

      }  
        public bool validateRespomse(char responsE)
        {
            if (Char.ToUpper(responsE) != 'Y' && Char.ToUpper(responsE) != 'N')
                return false;
            return true;
        }
        private void Screen()
        {
            Console.WriteLine("R=Камень");
            Console.WriteLine("P-Бумага");
            Console.WriteLine("S-Ножницы");
            Console.WriteLine("Пожалуйста, сделайте свой выбор:");
        }

        private bool validateSelection()
        {

            char value = Char.ToUpper(UserSelector);
            if(value != 'R'&& value != 'P'&& value != 'S')

                    return false ;
            return true;


        }
    
    
    
    
    }

}

