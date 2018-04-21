using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A22.Instrukcje_Skoku
{
    class Program
    {
        private static int wiek;
        private static string imie;
        static void Main(string[] args)
        {
            int[] tablicaZLatami = {1, 2, 3, 4, 6, 7, 8, 25, 45, 67 };
           
            //Instrukcje skoku. break, continue ,goto ,return ,throw (bedzie w wyjątkach).
            foreach (int wiek in tablicaZLatami)
            {
                // continue zamiast wychodzić z pętli pomijamy instrukcję po continue i przechodzimy do następnej  interacji pętli.
                if (wiek == 2)
                {

                    continue;
                    //jakaś instrukcja
                }
                //Jeśli wiek jest równy 4 wychodzimy z petli foreach - instrukcja break
                if (wiek == 4)
                {
                    break;
                }
            }

            foreach (int wiek in tablicaZLatami)
            {
                //jeśli napotkamy instrukcję goto to możemy przejść do etykiety skip - czyli przechodzimy (wykonujemy skok do skip) do zdefiniowanego kodu. Jeśli wiek bedzie równy 2 to przeskoczymy do etykiety skip. Cały kod pomiedzy zostanie pominięty. goto ten zaciemnia programowanie skacze po kodzie dlatego nie jest polecany.
                if (wiek == 2)
                {
                    goto skip2;
                }
                
            }
            // jakiś kod
            // od tej etykiety startujemy po instrukcji goto.
            skip2:
            Console.WriteLine("Hello");

            //Przykłady instrukcje continue, break
            foreach (int wiek in tablicaZLatami)
            {
                if (wiek == 2)
                {
                    Console.WriteLine("Wiek wynosi : {0}", wiek);
                    continue;
                    //ten kod nigdy sie nie wykona.
                    Console.WriteLine("Cześć");
                }
                if (wiek == 4)
                {
                    Console.WriteLine("Wiek wynosi : {0}", wiek);
                    break;
                    //ten kod nigdy sie nie wykona.
                    Console.WriteLine("Cześć");
                }
            }
            //instrukcja goto
            foreach (int wiek in tablicaZLatami)
            {
                if (wiek == 2)
                {
                    Console.WriteLine("Wiek wynosi : {0}", wiek);
                    goto skip;
                    //ten kod nigdy sie nie wykona.
                    Console.WriteLine("Cześć");
                }
             
            }
            //jakiś kod
            skip:
            Console.WriteLine("Cześć");

            int[] tablicaZLatami2 = { 1, 2, 3, 4, 6, 7, 8, 25, 45, 67 };
            // instrukcja return
            ZmienWiek(tablicaZLatami2);
            Console.ReadKey();

        }

        private static void ZmienWiek(int[] tablicaZLatami2)
        {
            foreach (var wiek in tablicaZLatami2)
            {
                if (wiek == 3)
                {
                    Console.WriteLine("Wiek wynosi : {0}", wiek);
                    return; //wychodzimy z metody i przechodzimy do kolejnej instrukcji.
                }
            }
        }
        #region metody prywatne        
        private static void SprawdzWiek(int[] tablicaZwiekami)
        {
            foreach (int wiek in tablicaZwiekami)
            {
                //instrukcje return mozna uzyc dla metod void, zwykle uzywamy jej do zwracania wartości.
                //Jeśli wiek bedzie równy 5 to return powoduje że wyskoczymy z metody kod po returnie nie zostanie wykonany.
                if (wiek == 5)
                {
                    return;
                }
            }
        }
        #endregion
        //Instrukcja throw - wyjątki.
    }
}
