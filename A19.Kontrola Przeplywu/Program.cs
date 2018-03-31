using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A19.Kontrola_Przeplywu
{
    class Program
    {
        private static int wiek;
        private static string imie;


        //Kontrola przepływu - Rozgałęzienia - If (Warunek).

        // if (age <= 10)
        //    Method1();
        //else if (age< 20)
        //    Method2();
        //Jeśli żaden wcześniejszy warunek nie został spełniony
        //else
        //Nawiasy klamrowe są wymagane gdy mamy wiecej metod - tutaj akurat zastosowaliśmy nawiasy dla czytelności kodu.
        //{
        //    Method3();
        //}
        // 
        //Operator 3 argumentowy. Jezeli wiek jest wiekszy od 18 Pełnoletni w przeciwnym wypadku Dziecko. - Szybkie Sprawdzenie.
        //string test = age > 18 ? "Pełnoletni" : "Dziecko";
        static void Main(string[] args)
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
            Console.ReadKey();
        }

        private static void Metoda4()
        {
            Console.WriteLine("Masz 30 i więcej lat");
        }

        private static void Metoda3()
        {
            Console.WriteLine("Twój wiek większy lub równy 20 a mniejszy od 30 i wynosi " + wiek);
        }

        private static void Metoda2()
        {
            Console.WriteLine("Twój wiek większy od 10 a mniejszy od 20 i wynosi " + wiek);
        }

        private static void Metoda1()
        {
            Console.WriteLine("Masz 10 lub mniej lat a dokładnie masz " + wiek);
        }
    }
}
