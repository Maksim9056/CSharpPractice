using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Камень_ножницы_бумага_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (; ; ) {
                Random random = new Random();
                int CheckUserWin = random.Next(1, 4);
                int computerChoice = CheckUserWin;
                Console.WriteLine();
                Console.WriteLine("1.Камень");
                Console.WriteLine("2.Ножницы");
                Console.WriteLine("3.Бумага");

                Console.Write("Ваш выбор? — ");
                string Using = Console.ReadLine();
                Console.WriteLine($"Выбор копьютера:{computerChoice}");
                if (int.TryParse(Using, out int Player))

                    Console.WriteLine($"Прошло проверку на число {Using} !");

                if (Player > 3 || Player < 1)
                    Console.WriteLine($"Не верное число {Player} !");
                else
                
                // Условия для победы
                    if ((Player == 1 && computerChoice == 2) ||
                        (Player == 3 && computerChoice == 1) ||
                        (Player == 2 && computerChoice == 3)
                       )
                        Console.WriteLine("Ты победил!");
                // Условия для поражения
                    if ((Player == 1 && computerChoice == 3) ||
                        (Player == 2 && computerChoice == 1) ||
                        (Player == 3 && computerChoice == 2))
                        Console.WriteLine("Вы проиграли");
                // Условия равенства
                    else if (Player == computerChoice)
                        Console.WriteLine("Ничья");

                    else Console.WriteLine();

                   /* if (Player == 3 && computerChoice == 1)
                        Console.WriteLine("Ты победил!");   */
  
                   /* if (Player == 2 && computerChoice == 3)
                        Console.WriteLine("Ты победил!");*/  
                      /* if (Player == 2 && computerChoice == 1)
                        Console.WriteLine("Вы проиграли");


                    if (Player == 3 && computerChoice == 2)
                        Console.WriteLine("Вы проиграли");*/                 
                   /*if (Player > computerChoice && Player > computerChoice)
                        Console.WriteLine("Ты победил!");
                    if (Player < computerChoice&& computerChoice > Player)
                    Console.WriteLine(" Вы проиграли");
                    else if (Player == computerChoice && Player == computerChoice)
                        Console.WriteLine("Ничья");
                    //Работа логики  камня 
                   // else if (Player == computerChoice && Player == computerChoice)
                   //     Console.WriteLine("Ничья2");
                    */
                 

            }
        }
    }
}