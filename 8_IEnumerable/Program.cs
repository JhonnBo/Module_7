using System.Collections;
namespace _8_IEnumerable
{
    class Club
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
            Console.WriteLine("{0}   {1}", Name, City);
        }
    }
    class League : IEnumerable
    {
        Club[] ar;  

        public League(Club[] clubs)
        {
            ar = new Club[clubs.Length];
            for (int i = 0; i < clubs.Length; i++)
            {
                ar[i] = new Club(clubs[i].Name, clubs[i].City);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return ar.GetEnumerator();
            //for (int i = 0; i < ar.Length; i++)
            //    yield return ar[i];
        }

        //Итератор представляет метод, в котором используется ключевое слово yield для
        //перебора по коллекции или массиву public IEnumerator GetEnumerator()

        //Перечислитель — это объект, который реализует необобщенный интерфейс IEnumerator
        //В интерфейсе IEnumerator определяется одно свойство, Current,
        //необобщенная форма: object Current { get; }

        //{
        //    Console.WriteLine("\nВыполняется метод GetEnumerator");
        //    for (int i = 0; i < ar.Length; i++)
        //        yield return ar[i];
        //    // При обращении к оператору yield return будет сохраняться текущее местоположение.
        //    // И когда foreach перейдет к следующей итерации для получения нового объекта, 
        //    // итератор начнет выполнение с этого местоположения.
        //}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Club[] c = new Club[6];
            c[0] = new Club("Динамо", "Киев");
            c[1] = new Club("Бавария", "Мюнхен");
            c[2] = new Club("Интер", "Милан");
            c[3] = new Club("Реал", "Мадрид");
            c[4] = new Club("Челси", "Лондон");
            c[5] = new Club("Арсенал", "Лондон");
            foreach (Club temp in c)
                temp.Show();
            Console.WriteLine("-----------------------------");
            League lg = new League(c);
            foreach (Club temp in lg)
                temp.Show();
            Console.WriteLine("-----------------------------");           
        }
    }
}