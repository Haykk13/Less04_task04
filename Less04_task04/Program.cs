using System;

namespace Less04_task04
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass instance = new MyClass();

            ((IInter1)instance).Meth1();
            ((IInter2)instance).Meth1();
            ((IInter2)instance).Meth2();

            Console.ReadKey();
        }
    }

    interface IInter1
    {
        void Meth1();
    }

    interface IInter2 : IInter1
    {
        void Meth2();
    }

    class MyClass : IInter2
    {
        public void Meth1()
        {
            Console.WriteLine("method 1");
        }
        public void Meth2()
        {
            Console.WriteLine("method 2");
        }
    }
}