using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A18.Zdarzenia
{
    class Program
    {
        //Zdarzenia (events)
        //Wielokrotnie w rozwoju oprogramowania potrzebujemy interakcji aby śledźić komponenty, które wykonują jakieś interesujące rzeczy w nieprzewidywalnym czasie. Na przykład przycisk na ekranie jest elementem, który chcemy śledzić, i chcemy wiedzieć, kiedy użytkownik klika ten przycisk. Nie wiemy dokładnie, kiedy użytkownik kliknie przycisk, ale możemy otrzymywać powiadomienia gdy użytkownik kliknie przycisk czyli gdy zajdzie zdarzenie klikniecia przycisku i wtedy możemy wykonać pewien kod w reakcji na to zdarzenie.Czasami musimy zapisać dane do pliku lub dane do bazy danych, lub musimy śledzić dane na dysku np dane odswierzane na giełdzie co 60 sek. Wszystko to są to przykłdy zdarzeń. Zdarzenia pozwalają na sledzenie obiektu np przycisku na ekranie. Zdarzenia pozwalają na ogłaszanie zdrzenia każdemu kto słucha że wydażyło się coś ciekawego. Np gdy klikniemy przycisk wtedy publikujemy to zdarzenie natomiast kod subskrybuje to zdarzenie. Zdarzenie może wykonać wiele elementów np zapisać do bazy, zmienić kolor itp. Wszystko to odbywa się poprzez magię delegatów w c#. Zdarzenia eventy są oparte na delegatach i korzystają z nich.
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();

            //2. Przy zdarzeniach nie potrzebujrmy   new NazwaSieZmieniaDelegate wystarczy przypisanie samej metody.
            //Kompilator sprytnie zapewnia kompatybilność z metodą.
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
            Console.WriteLine(dzienniczek.Nazwa);
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
