using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        #region Имя игрока
        Start:
            Console.WriteLine("Для того, чтобы начать игру, введите ваше имя:");
            Console.ForegroundColor = ConsoleColor.Red;
            string UserName = (Console.ReadLine());
            Console.ResetColor();
        #endregion


        #region Ввод данных игры
        StartSecond:
            Console.WriteLine($"Здравствуйте {UserName}! Введите количество стрелков:");
            Console.ForegroundColor = ConsoleColor.Green;
            int Num = int.Parse(Console.ReadLine());
            List<string>Anketa = new List<string>();
            List<string>DistanceMas = new List<string>();
            List<string>BowMas = new List<string>();
            List<double> ShotMas = new List<double>();
            Console.ResetColor();
            Console.WriteLine("Выберите параметры игры");
            Console.WriteLine("Дистанция между мишенью и стрелком: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" 1) 18 ;  2) 30  ; 3) 50 ");
            Console.ResetColor();
            Console.WriteLine("Внимание! Размер поля, Размер мишени, Высота мишеней зависят от дистанции ");


        DistanceBack:
            Console.WriteLine("Выберите дистанцию из предложенных, введя одну из цифр (1-3): ");
            Console.ForegroundColor = ConsoleColor.Green;
            string Distance = (Console.ReadLine());
            switch (Distance)
            {
                case "1":
                    Console.ResetColor();
                    Console.WriteLine("Размер поля: 18 метров +-10 см , Размер мишени: 40 см , Высота мишеней: 130 см над уровнем земли ");
                    DistanceMas.Add("18 м");
                    break;
                case "2":
                    Console.ResetColor();
                    Console.WriteLine("Размер поля: 30 метров +-15 см , Размер мишени: 80 см , Высота мишеней: 130 см над уровнем земли");
                    DistanceMas.Add("30 м");
                    break;
                case "3":
                    Console.ResetColor();
                    Console.WriteLine("Размер поля:50 метров +-15 см , Размер мишени: 80 см , Высота мишеней: 130 см над уровнем земли");
                    DistanceMas.Add("50 м");
                    break;
                default:
                    Console.ResetColor();
                    Console.WriteLine("Не то значение");
                    goto DistanceBack;
            }


            #endregion


        #region Регистрация стрелков


            for (int i = 1; i <= Num; i++)
            {
            
                Console.WriteLine("\n");
                Console.ResetColor();
                Console.WriteLine("Введите имя стрелка:");
                Console.ForegroundColor = ConsoleColor.Green;
                Anketa.Add(Console.ReadLine());
                Console.ResetColor();








                Console.WriteLine("\n");


                BowBack:
                Console.WriteLine("Выберите лук:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(" 1) Классический лук (recurve bow) ; 2) Блочный лук (compound bow)");
                Console.ForegroundColor = ConsoleColor.Green;
                string Bow = (Console.ReadLine());
                switch (Bow)
                {
                    case "1":
                        Console.ResetColor();
                        Console.WriteLine("Сила натяжения такого лука около 15-20 кг. Скорость полёта стрелы достигает 240 км/ч.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Наименьшая точность при стрельбе");
                        BowMas.Add("Классический лук (recurve bow)");
                        break;
                    case "2":
                        Console.ResetColor();
                        Console.WriteLine("В таких луках используется специальный механизм, который обеспечивает стреле более правильный разгон, а также облегчает процесс натяжения лука. Сила натяжения около 25-30 кг. Скорость полёта стрелы из такого лука достигает 320 км/ч.");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Наивысшая точность при стрельбе");
                        BowMas.Add("Блочный лук (compound bow)");
                        break;
                    default:
                        Console.ResetColor();
                        Console.WriteLine("Не то значение");
                        goto BowBack;
                }


                Console.WriteLine("\n");
                Console.ResetColor();
                Console.WriteLine($"Вы зарегистрированы на участие!");
               
                #endregion


        #region Стрельба
                Console.WriteLine("\n");
                Random Shoot = new Random();
                if (BowMas.Contains("Классический лук (recurve bow)"))
                {
                    
                  
                      int FirstShot= (Shoot.Next(0, 8));
                        int SecondShot= (Shoot.Next(0, 8));
                        int ThirsdShot= (Shoot.Next(0, 8));
                        
                        Console.WriteLine($"Произведен 1 выстрел. Вы получили {FirstShot} баллов");
                        Console.WriteLine($"Произведен 2 выстрел. Вы получили {SecondShot} баллов");
                        Console.WriteLine($"Произведен 3 выстрел. Вы получили {ThirsdShot} баллов");
                        double Shots = (FirstShot + SecondShot + ThirsdShot)/3;
                       
                        Console.WriteLine("\n");
                        Console.WriteLine($"Среднее значение: {Shots}");
                    
                }
                else
                {
                    Console.ResetColor();
                    for (int c = 1; c <= 3; c++)
                    {
                        int FirstShot = (Shoot.Next(7, 11));
                        int SecondShot = (Shoot.Next(7, 11));
                        int ThirsdShot = (Shoot.Next(7, 11));

                        Console.WriteLine($"Произведен {c} выстрел. Вы получили {FirstShot} баллов");
                        Console.WriteLine($"Произведен {c} выстрел. Вы получили {SecondShot} баллов");
                        Console.WriteLine($"Произведен {c} выстрел. Вы получили {ThirsdShot} баллов");
                        double Shots = (FirstShot + SecondShot + ThirsdShot)/3;
                        Console.WriteLine("\n");
                        Console.WriteLine($"Среднее значение: {Shots}");
                        ShotMas.Add(Shots);
                    }
                }
                
                }
            #endregion

            
        #region Введение жалоб или просьб
        OpinionBack:
            Console.WriteLine("Есть ли у Вас какие-либо жалобы или просьбы по поводу проведения соревнований? (введите да/нет)");
                Console.ForegroundColor = ConsoleColor.Green;
                string Opinion = (Console.ReadLine());
                Console.ResetColor();
            switch (Opinion)
            {
                case "да":

                OpinionSecond:
                    Console.WriteLine("Введите жалобу или просьбу:");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.ReadLine();
                    Console.ResetColor();
                OpinionThirzd:
                    Console.WriteLine("Если хотите написать еще жалобу или просьбу, введите (да/нет)");
                    Console.ForegroundColor = ConsoleColor.Green;
                    string OpinionSecond = (Console.ReadLine());
                    Console.ResetColor();
                    switch (OpinionSecond)
                    {
                        case "да":
                            Console.ResetColor();
                            goto OpinionSecond;
                        case "нет":
                            goto EndOpinion;
                        default:
                            Console.WriteLine("Пожалуйста, введите нет");
                            goto OpinionThirzd;
                    }
                EndOpinion:
                    break;

                case "нет":

                    Console.WriteLine("Мы рады, что у вас не возникло никаких вопросов!");
                    break;

                default:
                    Console.WriteLine("Не то значение");
                    goto OpinionBack;
            }
            Console.ResetColor();
            Console.WriteLine("Благодарим за участие в Олимпийских играх!");
            WantGameStart:
            Console.WriteLine($"{UserName}, хотите начать игру заново? (введите да/нет)");
            Console.ForegroundColor = ConsoleColor.Red;
            string PlayGame = (Console.ReadLine());
            Console.ResetColor();
            switch (PlayGame)
            {
                case "да":
                    Console.WriteLine("Добро пожаловать в новую игру!");
                    ChangeNameBack:
                    Console.WriteLine("Хотите изменить свое имя? (введите да/нет)");
                    Console.ForegroundColor = ConsoleColor.Red;
                    string ChangeUserName = (Console.ReadLine());
                    Console.ResetColor();
                    switch (ChangeUserName)
                        {
                        case "да":
                        goto Start;

                        case "нет":
                            goto StartSecond;

                        default:
                            Console.WriteLine("Не то значение");
                            goto ChangeNameBack;
                    }
                    break;

                case "нет":
                    Console.WriteLine("Благодарим за игру!");
                    break;

                default:
                    Console.WriteLine("Не то значение");
                    goto WantGameStart;
                    }
            #endregion

        Console.ReadKey();
        }
    }
}
                       
                        
