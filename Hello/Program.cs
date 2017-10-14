using System;


namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //     for (; ;) pętla w nieskończoności
            for (; ;)
            {
                Console.Write("Wpisz swoje imie: ");
                //Metoda ReadLine pobierze nam imie i przypisze do zmiennej.
                string name = Console.ReadLine();
                Console.WriteLine("Witaj " + name);

                Console.Write("Wpisz ile masz lat: ");
                //Parsujemy stringa na inta.
                //int age = int.Parse(Console.ReadLine());
                int age;
                bool result = int.TryParse(Console.ReadLine(), out age);

                if (age > 18)
                {
                    //Zmienia kolor w konsoli konsoli
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Brawo jesteś pełnoletni możesz wypić browara!");
                }
                else if (result == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wprowadziłeś nie poprawny wiek!");
                }
                else
                {
                    Console.WriteLine("Możemy Ci zaoferować mleko!");
                }

                Console.ReadKey();
                //Czyścimy ekran
                Console.Clear();
                //Resetujemy kolor
                Console.ResetColor();
            }
           

            //string name = args[0];
            //Console.WriteLine("Witaj Swiecie " + name);
            //Console.ReadLine();

            //foreach (var item in args)
            //{
            //    Console.WriteLine("Witaj Swiecie " + item);
            //    Console.ReadLine();
            //}
        }
    }
}
