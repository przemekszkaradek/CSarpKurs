using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Przy tworzeniu obiektu Osoba () - w nawiasach mamy dostęp do 4 konstruktorów.
            Osoba osoba = new Osoba();
            Osoba osoba2 = new Osoba(1, "Tomek");
            Osoba osoba3 = new Osoba(2, "Tomek", "Nowak");
            Osoba osoba4 = new Osoba(3, "Tomek", "Nowak", "Katowice", 18, "mężczyzna");
        }
    }
}
