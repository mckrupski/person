using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obiekty1
{
    enum Gender
    {
        M,
        K,
        Nieokreślony
    }

    class Person
    {
        // Pola przechowujące informacje o osobie
        private DateTime Birth;

        private Gender Gender;

        // Konstruktor - public, aby można było wywołać go spoza klasy
        public Person()
        {
            // Wygenerujmy sobie losową datę urodzenia
            Random r = new Random();

            // Wylosuj dzień, miesiąc i rok
            int day = r.Next(1, 31);
            int month = r.Next(1, 13);
            int year = r.Next(1920, 2024);

            // Ustaw datę urodzenia
            this.Birth = new DateTime(year, month, day);

            // Wylosuj płeć
            Array genders = Enum.GetValues(typeof(Gender));
            this.Gender = (Gender)genders.GetValue(r.Next(genders.Length));
        }

        // Getter i setter dla daty urodzenia
        public DateTime BirthDate
        {
            get { return this.Birth; }
            set { this.Birth = value; }
        }

        // Getter i setter dla płci
        public Gender GetGender
        {
            get { return this.Gender; }
            set { this.Gender = value; }
        }
    }
}
