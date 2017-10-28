using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Dzienniczek_Ucznia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tworzymy instancję obiektu dzienniczka(Tworzymy obiekt)
            Dzienniczek dzienniczek = new Dzienniczek();
            //dodajemy ocenę.
            //dzienniczek.DodajOcene(5);
            //dodajrmy f na końcu liczby i mówimy kompilatorowi jawnie że przekazujemy typ float.
            //dzienniczek.DodajOcene(8.5f);
            //dzienniczek.DodajOcene(4.7f);

            //float średnia = dzienniczek.ObliczanieSredniej();
            //float max = dzienniczek.PobierzMaxOcene();
            //float min = dzienniczek.PobierzMinimalnaOcene();

            //użytkownik wprowadza wartości - petal for nieskończona.
            for (; ;)
            {
                Console.WriteLine("Podaj ocenę z zakresu 1 -10");

                //Parsujemy float ponieważ z klawiatury mamy stringa // Robimy tak jak w projekcie Hello dodajemy parametr nastepnie go dodajemy z out i próbujemy parsować.
                float ocena;
                bool rezultat = float.TryParse(Console.ReadLine(), out ocena);

                
                //gdzy dajemy 11 to wychodzimy z pętli - break
                if(ocena == 11)
                {
                    break;
                }
                // Jeżeli wprowadzimy liczbę.
                //if (rezultat == true)
                if (rezultat) // zapis skrócony
                {
                    if(ocena > 0 && ocena <=10)
                    {
                        dzienniczek.DodajOcene(ocena);
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna liczba, podaj liczbę z zakresu 1-10");
                    }
                    
                }               
            }
            Console.WriteLine("Średnia twoich ocen to : " + dzienniczek.ObliczanieSredniej());
            Console.WriteLine("Najwyższa ocena to : " + dzienniczek.PobierzMaxOcene());
            Console.WriteLine("Najniższa ocena to : " + dzienniczek.PobierzMinimalnaOcene());
            Console.ReadKey();

            //Tworzymy więcej dzienniczków
            Dzienniczek dzienniczek2 = new Dzienniczek();
            Dzienniczek dzienniczek3 = new Dzienniczek();
            Dzienniczek dzienniczek4 = new Dzienniczek();
            Dzienniczek dzienniczek5 = new Dzienniczek();
        }
    }
}
