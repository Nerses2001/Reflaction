using System;

namespace Reflaction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type;
            // 1
            MyClass myClass = new MyClass();
            type = myClass.GetType();
            Console.WriteLine("MyClass.GetType()" + type);
            

            // 2
            type = Type.GetType("Reflaction.MyClass");
            Console.WriteLine("Type GetType()" + type);

            // 3
            type = typeof(MyClass);
            Console.WriteLine("typeof(MyClass)" + type);

            Console.ReadKey();

        }
    }
}
