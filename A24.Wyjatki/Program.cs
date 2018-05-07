using System;

namespace A24.Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wyjątki - w języku C# wyjątki obsługujemy za pomocą instrukcji catch.
            // Blok try - w tym bloku zamieszczamy instrukcje które chcemy wykonać a mogą nam rzucić wyjątek.
            // Blok try może być śledzony przez jeden lub wiecej bloków catch.
            // Jeżeli Metoda StatystykiDzienniczka rzuci wyjątek to wtedy przeszuka blok (lub bloki) catch i znajdzie instrukcje odpowiadające za dzielenie przez zero (DivideByZeroException) lub nie znajdzie odpowiedniego bloku catch i nie przechwyci wyjątku. Musimy być przygotowani na odpowiedni typ wyjątku.
            // Tylko jeden blok catch może zostać wykonany po bloku try 
            //Jeżeli mamy wiele bloków catch to jest to Łańcuchowa istrukcja catch.
            // Bloki są wykonywane od góry do dołu i dlatego u samej góry dodajemy najbardziej pasujące wyjątki.
            // Exception - wszystkie wyjątki dziedziczą z tej klasy.
            // Jest tylko kilka katastrofalnych wyjątków które nie można złapać.
            //Blok catch exception musi być ostatni ponieważ przechwytuje prawie wszystkie wyjątki - umieszczamy od najbardziej szczegółowych do najmniej ogólnych.

            //Przykład:
            //try
            //{
            //    StatystykiDzienniczka();
            //}
            //catch (DivideByZeroException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            Dzienniczek dzienniczek = new Dzienniczek();

           
            try
            {
                Console.WriteLine("Proszę podaj imię!");
                dzienniczek.Nazwa = Console.ReadLine();
            }
            //W zmiennej ex środowisko wykonawcze wyjątku zapisze nam obiekt wyjątku który został zgłoszony.
            //Dzięki wyjątkom nasz program może działać, nie zawiesza się.
            catch (ArgumentException ex)
            {
               
                Console.WriteLine( ex.Message);
                // ex.Message - komunikat, ex.StackTrace - ślad stodu w którym wystąpił wyjątek
                // Console.WriteLine(ex.StackTrace);
            }
            catch (NullReferenceException )
            {

                Console.WriteLine("Coś poszło nie tak.");
                // ex.Message - komunikat, ex.StackTrace - ślad stodu w którym wystąpił wyjątek
                // Console.WriteLine(ex.StackTrace);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            //finally
            //{

            //}
            dzienniczek.NazwaSieZmienia += (NazweZmieniono);
            dzienniczek.NazwaSieZmienia += (NazweZmieniono2);
            dzienniczek.NazwaSieZmienia += (NazweZmieniono3);
            dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += (NazweZmieniono4);
            //Pomimo dodania nulla poprzednie zdarzenia sie nie kasują ponieważ zapisane są jako zdarzenia i nie zostały nadpisane. Mozemy jedynie dodać lub usunąć subskrybenta zdarzenia a nie dodać nowy kod !!!
            //dzienniczek.NazwaSieZmienia += null;

            // Usuwamy 3 subskrypcje dla metody NazweZmieniono4 - mamy jedną subskrybcje.
            dzienniczek.NazwaSieZmienia -= (NazweZmieniono4);

            dzienniczek.NazwaSieZmienia -= (NazweZmieniono4);
            dzienniczek.NazwaSieZmienia -= (NazweZmieniono4);

            dzienniczek.Nazwa = "Dzienniczek Marcina";
            dzienniczek.Nazwa = "Przemek Hej";
            Console.WriteLine( dzienniczek.Nazwa);
            Console.ReadKey();
        }
        // W konwencji dot .net zdarzenia w 99 procentach zachodzą z dwoma parametrami.
        // Pierwszy parametr nadawca zdarzenia drugi zawieraz wszystkie argumenty(informacje) o tym zdarzeniu.
        //Co oznacza że musimy stworzyć specjalną klase z 2 własciowościami z istniejącą nazwą i nową nazwą w jednym obiekcie, jednej klasie.
        //5. W metodach musimy zmienić (zastosować) sygnatury parametrów object sender, ZmienNazweEventArgs args
        //Nastepnie aby dostać się do właściwości posługujemy się args - nasz delegat przyjmuje obiekt i argumenty.
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
    }    
}
