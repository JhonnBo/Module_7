using static System.Net.Mime.MediaTypeNames;

namespace _4_Dynamic_Binding
{
    interface IBase
    {
        void F();
    }
    class Base : IBase
    {
        public virtual void F()
        {
            Console.WriteLine("It's base!");
        }
    }
    class Derived : Base
    {
        public override void F()
        {
            Console.WriteLine("It's derived!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.F(); // F - из класса Derived
            IBase obj = d;
            obj.F(); // F - из класса Derived
        }
    }
}