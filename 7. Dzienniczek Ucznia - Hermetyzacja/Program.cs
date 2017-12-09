using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _7.Dzienniczek_Ucznia___Hermetyzacja
{
    class Program
    {
        static void Main(string[] args)
        {
            Dzienniczek dzienniczek = new Dzienniczek();

            dzienniczek.DodajOcene(5);
            dzienniczek.DodajOcene(8.5f);
            dzienniczek.DodajOcene(4.7f);
            dzienniczek.DodajOcene(2.7f);
            //Wszystkie statystyki obliczone są przechowywane w obiekcie statystyki dzienniczka. 
            // + dodajemy nasze wartości do stringa

            StatystykiDzienniczka statystyki = dzienniczek.CompletneStatystyki();

            Console.WriteLine("Średnia ocena " + statystyki.sredniaOcena);
            Console.WriteLine("Maksymalna ocena " +statystyki.maxOcena);
            Console.WriteLine("Minimalna ocena " + statystyki.minimalnaOcena);
            
            // Dzienniczek 2
            Dzienniczek dzienniczek2 = new Dzienniczek();

            dzienniczek2.DodajOcene(5);
            dzienniczek2.DodajOcene(3.5f);
            dzienniczek2.DodajOcene(8.7f);
            dzienniczek2.DodajOcene(5.7f);

            //Ystawiamy nowe wartosci z dzienniczka 2
            statystyki = dzienniczek2.CompletneStatystyki();

            Console.WriteLine("Średnia ocena " + statystyki.sredniaOcena);
            Console.WriteLine("Maksymalna ocena " + statystyki.maxOcena);
            Console.WriteLine("Minimalna ocena " + statystyki.minimalnaOcena);
        }
    }
}