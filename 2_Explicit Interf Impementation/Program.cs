namespace _2_Explicit_Interf_Impementation
{
    interface IMyIF_A
    {
        int math(int x);
    }

    interface IMyIF_B
    {
        int math(int x);
    }

    class A : IMyIF_A, IMyIF_B
    {
        // Одна общая реализация для обоих интерфейсов
        public int math(int x)
        {
            return x + x;
        }
    }

    // В классе B реализованы оба интерфейса
    class B : IMyIF_A, IMyIF_B
    {
        // Явным образом реализуем два метода math()
        int IMyIF_A.math(int x)
        {
            return x + x;
        }
        int IMyIF_B.math(int x)
        {
            return x * x;
        }
        // Вызываем метод math() посредством ссылки на интерфейс
        public int methA(int x)
        {
            IMyIF_A a_ob;
            a_ob = this;
            return a_ob.math(x); // Имеется в виду интерфейс IMyIF_A
        }
        public int methB(int x)
        {
            IMyIF_B b_ob;
            b_ob = this;
            return b_ob.math(x); // Имеется в виду интерфейс IMyIF_B
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            A obj1 = new A();
            Console.Write("Вызов метода A.meth(): ");
            Console.WriteLine(obj1.math(7));
            IMyIF_A ia = obj1;
            Console.Write("Вызов метода IMyIF_A.meth(): ");
            Console.WriteLine(ia.math(7));
            IMyIF_B ib = obj1;
            Console.Write("Вызов метода IMyIF_B.meth(): ");
            Console.WriteLine(ib.math(7));

            B obj2 = new B();
            Console.Write("Вызов метода IMyIF_A.meth(): ");
            Console.WriteLine(obj2.methA(3));
            Console.Write("Вызов метода IMyIF_B.meth(): ");
            Console.WriteLine(obj2.methB(3));

            IMyIF_A b = obj2;
            Console.Write("Вызов метода IMyIF_A.meth(): ");
            Console.WriteLine(b.math(4));
            Console.Write("Вызов метода IMyIF_B.meth(): ");
            Console.WriteLine((obj2 as IMyIF_B).math(4));
        }
    }


}