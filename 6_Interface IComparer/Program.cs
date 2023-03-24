using System.Collections;
// Существует возможность «научить» класс сортироваться по определённому критерию 
// Для этого необходимо отнаследовать класс от интерфейса IComparer
namespace _6_Interface_IComparer
{
    public class Club
    {
        public string Name { get; set; }
        public string City { get; set; }
        public Club(string name, string city)
        {
            this.Name = name;
            this.City = city;
        }
        public Club() : this("Динамо", "Киев") { }
        public void Show()
        {
            Console.WriteLine("{0}\t{1}", Name, City);
        }
    }
    public class SortByName : IComparer
    { 
        public int Compare(object? x, object? y)
        {
            if(x is Club club1 && y is Club club2) {
            return club1.Name.CompareTo(club2.Name);
            }
            throw new NotImplementedException();
        }
    }
    public class SortByCity : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Club club1 && y is Club club2)
            {
                return club1.City.CompareTo(club2.City);
            }
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
            Array.Sort(c, new SortByName());
            Console.WriteLine("\nМассив, упорядоченный по имени:");
            foreach (Club temp in c)
                temp.Show();
            Array.Sort(c, new SortByCity());
            Console.WriteLine("\nМассив, упорядоченный по городу:");
            foreach (Club temp in c)
                temp.Show();
        }
    }
}