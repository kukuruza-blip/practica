using System;

namespace PracticeWork1
{
    public class Firm
    {
        public string Name;
        public string Address;
        public int FoundingYear;

        // Конструктор с параметрами для инициализации полей
        public Firm(string name, string address, int year)
        {
            Name = name;
            Address = address;
            FoundingYear = year;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Firm myFirm = new Firm("Техно-Горизонт", "ул. Ленина, 5", 2010);

            Console.WriteLine($"Фирма: {myFirm.Name}, Год: {myFirm.FoundingYear}");
        }
    }
}