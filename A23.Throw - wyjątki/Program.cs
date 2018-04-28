
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A23.Throw.Wyjatki
{
    class Program
    {
        static void Main(string[] args)
        {

            // Wyjątki - słowo kluczowe Throw w c# służy do zgłaszania wyjątków.
            //Wyjątków używamy tylko gdy oprogramowanie znajduje się w pozycji gdzie nie można się posunąc do przodu np
            //Gdy mamy złą wartość wejściową wprowadzoną przez użytkownika, Gdy brakuje pamięci, Gdy sieć nie działa,
            //Gdy rzucasz wyjątkiem rzucasz obiektem.
            //Program po wystąpieniu błedu lepiej zakonćzyć ponieważ może działać nie prawidłowo, zwracać złe dane, wyniki. 
            //np.
            // W opisie podajemy informacje o wygnerowanym bledzie 
            //if (wiek == 21)
            //{
            //    throw new ArgumentException("21 jest nie dozwoloną liczbą");
            //}

            //Stos - podczas wykonywania programu wywołujemy metodę która może wywołać inną metodę a ta z koleji jeszcze inną metodę -tak tworzona struktura danych nazywana jest stosem. Przy każdej metodzie która jest wywoływana coś jest wypychane na stos.


            Dzienniczek dzienniczek = new Dzienniczek();
            //WYJATKI 2. Uruchamiamy control + F5
            //Zawsze zwracamy uwagę na stos - podczas wykonywania programu wywołujemy metodę która może wywołać inną metodę a ta z koleji jeszcze inną metodę - tak tworzona struktura danych nazywana jest stosem. Przy każdej metodzie która jest wywoływana coś jest wypychane na stos.
            //Dla wyjątków powinniśmy zrobić obsługę!
            dzienniczek.Nazwa = null;
           
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono);            
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono2);           
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono3);
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono4);
            dzienniczek.NazwaSieZmienia += new NazwaSieZmieniaDelegate(NazweZmieniono4);

            dzienniczek.Nazwa = "Dzienniczek Marcina";
            dzienniczek.Nazwa = "Przemek Hej";
            Console.WriteLine(dzienniczek.Nazwa);
            Console.ReadKey();
        }
       
        private static void NazweZmieniono(string nazwaJuzIstniejaca, string nowaNazwa)
        {
           
            Console.WriteLine($"Zmiana nazwy z {nazwaJuzIstniejaca} na {nowaNazwa}");
        }

        private static void NazweZmieniono2(string nazwaJuzIstniejaca, string nowaNazwa)
        {

            Console.WriteLine("*******************");
        }

        private static void NazweZmieniono3(string nazwaJuzIstniejaca, string nowaNazwa)
        {

            Console.WriteLine("Cześć");
        }

        private static void NazweZmieniono4(string nazwaJuzIstniejaca, string nowaNazwa)
        {

            Console.WriteLine("++++++++++++++++++");
        }
    }
}
