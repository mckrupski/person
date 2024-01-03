using System;

namespace Obiekty1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utwórz obiekt klasy Person
            Person person = new Person();

            // Pobierz i wyświetl informacje o osobie
            Console.WriteLine("Data urodzenia: " + person.BirthDate);
            Console.WriteLine("Płeć: " + person.GetGender);

            // Poczekaj na naciśnięcie klawisza przed zakończeniem programu
            Console.ReadLine();
        }
    }
}
