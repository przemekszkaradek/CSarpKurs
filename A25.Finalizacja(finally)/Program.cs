using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A25.Finalizacja_finally_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finalziacja (finally)

            //Ostatnia klauzula po try catch dodaje blok finally.
            // Instrukcja finally umożliwia określenie bloku kodu który będzie zawsze wykonany nawet gdy nie istnieje wyjątek wewnątrz bloku try. Jedynym środowiskiem wykonawczym zarządzanym w .NET jest pamięć.



            //Przykład
            //StreamWriter file = new StreamWriter("plik.text");
            //try
            //{
            //    file.WriteLine("Witaj piszemy do pliku tekstowego");
            //}
            //finally
            //{

            //Ważnym jest żeby wykorzystywane pliki dane czyli rózne zasoby zamknąć za sobą ponieważ możemy doprowadzić do uszkodzenia danych. -Poniżej przykład, metoda Close()
            //    file.Close();
            //}

            //Instrukcja using - prezenuje bloki try finally w czystszy sposób.
            //Jest to instrukcja która sprawia że obiekt jest odpowienio rozmieszczany a zasoby są zwalniane nawet jeśli wystąpi wyjątek. Poniższy plik zostanie usuniety i poprawnie zamknięty (nie będzie niczego blokował).
            //using (StreamWriter file1 = new StreamWriter("plik.text", true))
            //{
            //    file1.WiriteLine("Witaj piszemy do pliku tekstowego !!!");
            //}


            #region stary kod


            //Dzienniczek dzienniczek = new Dzienniczek();


            //try
            //{
            //    Console.WriteLine("Proszę podaj imię!");
            //    dzienniczek.Nazwa = Console.ReadLine();
            //}

            //catch (ArgumentException ex)
            //{

            //    Console.WriteLine(ex.Message);

            //}
            //catch (NullReferenceException)
            //{

            //    Console.WriteLine("Coś poszło nie tak.");

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{

            //}



            //dzienniczek.NazwaSieZmienia += (NazweZmieniono);
            //dzienniczek.NazwaSieZmienia += (NazweZmieniono2);
            //dzienniczek.NazwaSieZmienia += (NazweZmieniono3);
            //dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            //dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            //dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            //dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            //dzienniczek.NazwaSieZmienia -= (NazweZmieniono4);
            //dzienniczek.NazwaSieZmienia -= (NazweZmieniono4);
            //dzienniczek.NazwaSieZmienia -= (NazweZmieniono4);

            //dzienniczek.Nazwa = "Dzienniczek Marcina";
            //dzienniczek.Nazwa = "Przemek Hej";
            //Console.WriteLine(dzienniczek.Nazwa);
            //Console.ReadKey();
            #endregion
            //Jezeli chcemy podac konkretna sciezke to robimy tak:c:\\katalog\\plik.txt 
            //Jezeli chcemy zapisać w katalogu \bin\Debug to robimy tak plik.txt
            StreamWriter plik = new StreamWriter("c:\\katalog\\plik.txt", false);

            try
            {
                Console.WriteLine("Podaj swoje imie:");
                string imie = Console.ReadLine();

                plik.WriteLine(imie);
                plik.WriteLine("Witaj piszemy do pliku tekstowego");
            }
            finally
            {
                //Ta sekcja wykonuje się zawsze.
                //Plik zamykamy zwalniamy zasoby.
                plik.Close();
            }
            //true - pozwala dopisać linię 2 false - nadpisuje to co mamy.
            // Instrukcja using zapewnia nam że plik zostanie zamknięty a zasoby zwolnione.
            using (StreamWriter plik2 = new StreamWriter("c:\\katalog\\plik.txt", true))
            {
                plik2.WriteLine("Witaj piszemy do pliku tekstowego linia 2 !!!");
            }
        }

        #region Metody Prywatne      
        private static void NazweZmieniono(object sender, ZmienNazweEventArgs args)
        {

            Console.WriteLine($"Zmiana nazwy z {args.IstniejacaNazwa} na {args.NowaNazwa}");
        }

        private static void NazweZmieniono2(object sender, ZmienNazweEventArgs args)
        {

            Console.WriteLine("*******************");
        }

        private static void NazweZmieniono3(object sender, ZmienNazweEventArgs args)
        {

            Console.WriteLine("Cześć");
        }

        private static void NazweZmieniono4(object sender, ZmienNazweEventArgs args)
        {

            Console.WriteLine("++++++++++++++++++");
        }
        #endregion
    }
}
