using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A21.Petle
{
    class Program
    {

        private static int wiek;
        private static string imie;
        static void Main(string[] args)
        {
            //Petle
            //Dzieki pętli wykonujemy wielokronie dany blok kodu.

            //for - w pętli for musimy mieć określoną ilość razy wykonania. (int i = 0 inicjalizacja pętli, i < wiek warunek pętli,  i++ inkrementacja pętli - zwiększanie.) Jeżeli warunek w pętli jest prawdziwy to blok będzie wykonywany jeżeli nie to program przejdzie do lini pierwszej bezpośrednio po pętli.
            for (int i = 0; i < wiek; i++)
            {
                //instrukcje lub blok instrukcji które mają się wykonać w pętli.
                Console.WriteLine(i);
            }

            //while - pętla wykonywana jest tak długo jak prawdziwy jest warunek. Tutaj sprawdzany jest tylko warunek.
            //np czy wiek jest większy od 0. Najpierw sprawdzany jest warunek. Jeżeli warunek będzie fałszywy pętla nie wykona się ani razu.
            while (wiek > 0)
            {
                wiek--;
                Console.WriteLine(wiek);
            }

            //do while - odwrotnie jak w pętli while warunek sprawdzany na końcu. Gwarancja że kod pętli wykona się przynajmniej raz - najpierw wykonywane są instrukcję w pętli na końcu warunek. Dokąd warunek jest prawdziwy - pętla jest wykonywana.
            do
            {
                wiek++;
                Console.WriteLine(wiek);
            } while (wiek < 60);

            //foreach - ta pętla służy do perowania na tablicy łańcuchu lub kolekcji. Największą różnicą w stosunku do pętli for jest to że nie możemy zmieniać danych po których literujemy - dane te są tylko do odczytu.  Zaletą  tej pętli jest zapobieganie przekroczenia indeksu tablicy lub bufora. Identyfikator var item pobiera po koleji każdy element. Nie wyjdziemy poza zakres tablicy. W pętli for możemy np w warunku ustawić 10 elementów a mieć w tablicy jedynie 8 i wtedy wyjdziemy poza zakres tablicy.
            int[] tablicaZwiekami = { 2, 4, 6, 7, 8, 25, 45, 67, 72, 74 };
            foreach (var item in tablicaZwiekami)
            {
                Console.WriteLine(item);
            }

            //instrukcjaSwitch();

            //Zastosowanie pętli - przykład zagnieżdzanie.
            for (int i = 0; i < 3; i++)
            {
                for (int a = 0; a < 2; a++)
                {
                    Console.WriteLine("wartość i: {0} oraz watość a: {1}", i, a);
                }

            }

            int k = 1;
            while (k < 3)
            {
                Console.WriteLine("wartość i {0}", k);
                k++;
            }

            //Ta pętla nie wykona się ani razu - warunek nie jest spełniony - warunek sprawdzany na początku.
            //int k = 1;
            //while (k > 3)
            //{
            //    Console.WriteLine("wartość i {0}", k);
            //    k++;
            //}


            // Mimo że warunek jest fałszywy ta pętla wykona się raz ponieważ warunek jest sprawdzany na końcu.
            int j = 1;
            do
            {
                Console.WriteLine("wartość i w petli do while {0}", j);
                j++;
            } while (j > 3);

            //foreach - nie przekraczymy zakresu.

            string[] tablica = { "jeden", "dwa", "trzy", "cztery", "pięć", "dwanaście", "dwadzieścia jeden" };
            foreach (var item in tablica)
            {
                Console.WriteLine(item);
            }


            int[] tab = { 1, 2, 3, 5, 8, 12, 21 };
            foreach (var item in tab)
            {
                Console.WriteLine(item);
            }

            //for - z określoną długością tablicy.
            string[] tab2 = { "jeden", "dwa", "trzy", "cztery", "pięć", "dwanaście", "dwadzieścia jeden" };
            for (int h = 0; h < tab2.Length; h++)
            {
                Console.WriteLine("Element z tablicy: {0}", h);
            }

            //Petla nie skończona.

            for (;;)
            {
                Console.WriteLine("Podaj imię");
                string tekst = Console.ReadLine();

                Console.WriteLine("Masz na imię {0}", tekst);
            }

            //Petla nie skończona.
            //for (;;)
            //{
            //    Console.WriteLine("Hello");
            //}

            // Podświetla ponieważ poniższa instrukcja jest nie osiągalna ze względu na pętle nie skończoną.
            Console.ReadKey();
        }

        private static void instrukcjaSwitch()
        {
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
            Console.WriteLine("Jesteś w metodzie 1");
        }
    }
}
