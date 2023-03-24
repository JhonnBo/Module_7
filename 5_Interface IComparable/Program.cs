namespace _5_Interface_IComparable
{
    class Club : IComparable
    {
        string name;
        string city;
        public Club(string name, string city)
        {
            this.name = name;
            this.city = city;
        }
        public Club() : this("Динамо", "Киев") { }
        public void Show()
        {
            Console.WriteLine("{0}   {1}", name, city);
        }

        public int CompareTo(object? obj)
        {
            if (obj is Club club)
                return name.CompareTo(club.name);
                throw new NotImplementedException();
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Club[] c = new Club[6];
            Console.WriteLine("Неупорядоченный массив:");
            c[0] = new Club("Динамо", "Киев");
            c[1] = new Club("Арсенал", "Лондон");
            c[2] = new Club("Интер", "Милан");
            c[3] = new Club("Бавария", "Мюнхен");
            c[4] = new Club("Челси", "Лондон");
            c[5] = new Club("Реал", "Мадрид");
            foreach (Club temp in c)
                temp.Show();
            Array.Sort(c);
            Console.WriteLine("\nУпорядоченный массив:");
            foreach (Club temp in c)
                temp.Show();
        }
    }
}