using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Constructors
{
    //Konstruktor inicjalizuje pola składowe, w przypadku gdy nie zainicjalizujemy go żadnymi polami - zostanie mu przypisana wartość domyślna czyli 0 flase lub null w zaleźności od typu.
    class Osoba
    {
        int id;
        string imie;
        string nazwisko;
        string adres;
        int wiek;
        string plec;

        //ctor 2 x tab
        //Inicjalizujemy w tym konstruktorze pola wartościami domyślnymi.
        public Osoba()
        {
            id = 1;
            imie = "Marcin";
            nazwisko = "Kowal";
            wiek = 14;
        }
        //Inicjalizujemy w tym konstruktorze parametrami
        public Osoba(int id, string imie, string nazwisko, string adres, int wiek, string plec)
        {
            // Aby rozróżnić id od id piszemy słowko "this" co oznacza że to id tyczy sie naszego obiektu 
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = adres;
            this.wiek = wiek;
            this.plec = plec;
        }

        // Przeciązanie konstruktorów - róznią sie liczbą parametrów lub przypisywaniem wartości - przykład tylko z inicjalizacją 3 pól.
        // Reszta przyjmie wartości domyślne - 0, null, false
        //Inicjalizujemy w tym konstruktorze polami domyślanymi oraz parametrami a jedno pole nie zostało zainicjalizwoane wogóle. 
        public Osoba(int id, string imie, string nazwisko)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.adres = "Katowice";
            this.wiek = 18;
        }
        //Inicjalizujemy w tym konstruktorze tylko 2 pola parametrami przekazanymi do konstruktora.
        public Osoba(int id, string imie)
        {
            this.id = id;
            this.imie = imie;
            //pozostałe wartości domyślne
        }
    }
}
