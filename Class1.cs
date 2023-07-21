using System;

namespace Reflaction
{
    internal class Class1 : IInteface1, IInterface2
    {
        
        // Field
        private int myInt;
        private string myString = "Hello";

        public Class1() { }
        public Class1 (int input) 
        { 
            this.myInt = input;
        }

        // Proportes
        public int MyProp 
        {
            get => myInt;
            set => myInt = value;
        }
        public string MyString 
        {
            get => myString; 
        }

        // Methodes
        public void Method1() {}

        public void Methode2() { }

        private void Method3(string s1, string s2) 
        {
            Console.WriteLine(s1 + s2);
        }
        public void MethodA(){}
    }
}
