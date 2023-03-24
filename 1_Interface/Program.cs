using System.Drawing;

namespace _1_Interface
{
    internal class Program
    {
        static Random rnd = new Random();
        public static IFigure GeneratorOfFigures()
        {
            int n = rnd.Next(2);
            switch (n)
            {
                case 0: return new Rectangle(10.5, 6.5);
                case 1: return new Circle(10);
                default: return null;
            }
        }
        static void Main(string[] args)
        {

            IFigure[] p = new IFigure[10];
            int count_rectangle = 0, count_circle = 0;
            for (int i = 0; i < 10; i++)
            {
                p[i] = GeneratorOfFigures();
                if (p[i] is IFigureAngle)
                    count_rectangle++;
                if (p[i] as IFigureRound != null)
                    count_circle++;
                p[i].FigureType();
            }
            Console.WriteLine("\nКоличество прямоугольников: " + count_rectangle);
            Console.WriteLine("Количество окружностей: " + count_circle);

            Rectangle rect = new Rectangle(8, 10);
            rect.FigureType();
            rect.Area();
            rect.Diagonal();
            rect.PropA = 6;
            rect.PropB = 7;
            rect.Area();
            rect.Diagonal();
            rect.Perimetr();

            Circle crl = new Circle(12);
            crl.FigureType();
            crl.Area();
            crl.Length();
            crl.PropA = 6;
            crl.Area();
            crl.Length();

            IFigureAngle obj = rect;
            obj.FigureType();
            obj.Area();
            obj.Diagonal();
            obj.PropA = 3;
            obj.PropB = 4;
            obj.Area();
            obj.Diagonal();
            (obj as Rectangle).Perimetr(); // Такого метода в интерфейсе нет

            IFigureRound obj2 = crl;
            obj2.FigureType();
            obj2.Area();
            obj2.Length();
            obj2.PropA = 3;
            obj2.Area();
            obj2.Length();
        }
    }

    class Rectangle : IFigureAngle
    {        
        public Rectangle(double width, double height)
        {
            PropA = width;
            PropB = height;
        }
        public double PropA { get; set; }
        public double PropB { get; set; }
        public void Diagonal()
        {
            Console.WriteLine("Длина диагонали равна: {0:F2}",
                Math.Sqrt(Math.Pow(PropA, 2) + Math.Pow(PropB, 2)));
        }
        public void FigureType()
        {
            Console.WriteLine("Прямоугольник");
        }
        public void Perimetr()
        {
            Console.WriteLine("Периметр прямоугольника равна: {0:F2}", 2 * (PropA + PropB));
        }
        public void Area()
        {
            Console.WriteLine("Площадь прямоугольника равна: {0:F2}", PropA * PropB);
        }
    }

    class Circle : IFigureRound
    {       
        public Circle(double radius)
        {
            PropA = radius;
        }
        public double PropA { get; set; }
        public void Area()
        {
            Console.WriteLine("Площадь окружности равна: {0:F2}", Math.PI * Math.Pow(PropA, 2));
        }
        public void FigureType()
        {
            Console.WriteLine("Окружность");
        }
        public void Length()
        {
            Console.WriteLine("Длина окружности равна: {0:F2}", 2 * Math.PI * PropA);
        }
    }

}