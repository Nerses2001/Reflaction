using System;
using System.Reflection;

namespace Reflaction
{
    internal class Program
    {
        static void Main()
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

            Class1 class1 = new Class1();
            ListOfVar(class1);
            ListOfMethod(class1);
            ListOfField(class1);
            ListOfProps(class1);
            ListOfConstructor(class1);
            ListOfInterfase(class1);
            Console.WriteLine(new string('_', 60));
            Type type1 = class1.GetType();
            MethodInfo method = type1.GetMethod("Method3", BindingFlags.Instance | BindingFlags.NonPublic);
            method.Invoke(class1, new object[] {"Hello", "World"});
            FieldInfo fieldInfo = type1.GetField("myString", BindingFlags.Instance | BindingFlags.NonPublic);
            fieldInfo.SetValue(class1, "World" );
            Console.WriteLine(class1.MyString);


            Console.ReadKey();

        }



        static void ListOfVar(Class1 class1)
        {
            Console.WriteLine(new string('_', 30));
            Type t = class1.GetType();
            Console.WriteLine("Full naem   {0}", t.FullName);
            Console.WriteLine("Base class   {0}",t.BaseType);
            Console.WriteLine("IsAbstractt   {0}", t.IsAbstract);
            Console.WriteLine("IsCome object   {0}", t.IsCOMObject);
            Console.WriteLine("Is Seald   {0}", t.IsSealed);
            Console.WriteLine("Is Class   {0}", t.IsClass);

        }
        static void ListOfMethod(Class1 class1)
        {
            Console.WriteLine(new string('_', 30));
            Type t = class1.GetType();
            MethodInfo[] methodInfos = t.GetMethods(
                BindingFlags.Instance | 
                BindingFlags.Static | 
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.DeclaredOnly
                );
            foreach(var methodInfo in methodInfos) 
            {
                Console.WriteLine("Mthode  {0}" , methodInfo.Name);
            }

        }

        static void ListOfField(Class1 class1)
        {
            Console.WriteLine(new string('_', 30));
            Type t = class1.GetType();
            FieldInfo[] fieldsInfos = t.GetFields(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.DeclaredOnly
                );
            foreach (var f in fieldsInfos)
            {
                Console.WriteLine("Field  {0}", f.Name);
            }

        }

        static void ListOfProps(Class1 class1)
        {
            Type t = class1.GetType();
            PropertyInfo[] propInfos = t.GetProperties(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.DeclaredOnly
                );
            foreach (var p in propInfos)
            {
                Console.WriteLine("Property  {0}", p.Name);
            }

        }
        static void ListOfConstructor(Class1 class1)
        {
            Console.WriteLine(new string('_', 30));
            Type t = class1.GetType();
            ConstructorInfo[] constructorInfos = t.GetConstructors(
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.Public |
                BindingFlags.NonPublic |
                BindingFlags.DeclaredOnly
                );
            foreach (var c in constructorInfos)
            {
                Console.WriteLine("Constructor  {0}", c.Name);
            }

        }

        static void ListOfInterfase(Class1 class1)
        {
            Console.WriteLine(new string('_', 30));
            Type t = class1.GetType();
            var t1 = t.GetInterfaces();
           
            foreach (var c in t1)
            {
                Console.WriteLine("Interfase  {0}", c.Name);
            }

        }
    }
   
}
