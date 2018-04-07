using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A20.Switch
{
    class Program
    {
        private static int wiek;
        private static string imie;

        static void Main(string[] args)
        {
            //Switch - instrukcja ta to rozgałęzenie pozwalające na sprawdzenie wielu warunków zależnie od wartości zmiennej. Switch jest instrukcją wyboru która wybiera jeden przełącznik (case) w zależności o wyniku warunku.
            //na podstawie dopasowania zmiennej (imie)
            //break - wyjscie z bloku switch case.
            //Jezeli zaden warunek nie zostanie spełniony zostanie wykonany default:
            //    switch (imie)
            //    {
            //        case "Marcin":
            //            Metoda1();
            //            break;
            //        case "Tomek":
            //            Metoda2();
            //            Metoda3();
            //            break;
            //        default:
            //            Metoda4();
            //            break;
            //    }
            //}
            //InstrukcjeIf();

            Console.WriteLine("Podaj imie: ");
            imie = Console.ReadLine();
            switch (imie)
            {
                case "Marcin":
                    Metoda1();
                    break;
                case "Tomek":
                    Metoda2();
                    Metoda3();
                    break;
                case "Ania":
                    Metoda1();
                    Metoda2();
                    Metoda3();
                    Metoda4();
                    break;
                default:
                    Metoda4();
                    break;
            }

            Console.ReadKey();
        }

        private static void InstrukcjeIf()
        {
            Console.WriteLine("Podaj swój wiek: ");
            wiek = int.Parse(Console.ReadLine());
            //Operator 3 argumentowy
            string test = wiek > 18 ? "Pełnoletni" : "Dziecko";
            Console.WriteLine(test);
            Console.ReadKey();

            Console.WriteLine("Podaj swój wiek: ");
            wiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swoje imię: ");
            imie = Console.ReadLine();
            if (wiek <= 10)
            {
                if (imie == "Marcin")
                {
                    Metoda1();
                }

            }
            else if (wiek < 20)
            {
                Metoda2();
            }
            else if (wiek < 30)
            {
                Metoda3();
            }
            //Jeśli żaden wcześniejszy warunek nie został spełniony - else      
            else
            {
                Metoda4();
            }
        }

        private static void Metoda4()
        {
            Console.WriteLine("Jesteś w metodzie 4");
        }

        private static void Metoda3()
        {
            Console.WriteLine("Jesteś w metodzie 3");
        }

        private static void Metoda2()
        {
            Console.WriteLine("Jesteś w metodzie 2");
        }

        private static void Metoda1()
        {
            Console.WriteLine("Jesteś w metodzie 1" );
        }
    }
}
