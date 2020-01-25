using System;

namespace Ksu.Cis300.EditorConfigDemo
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }

    class aClass { } // Not OK
    class AClass // OK
    {
        private void method(string Param) { } // Not OK
        private int Method(string param) // OK
        {
            int LocalVariable = 0; // Not OK
            int localVariable = 0; // OK

            method("");

            return LocalVariable + localVariable;
        }

        public int property { get; } // Not OK
        public int Property { get; } // OK

        public const int publicConstant = 3; // Not OK
        public const int PublicConstant = 3; // OK

        private int privateField; // Not OK
        private int PrivateField; // Not OK
        private int _PrivateField; // Not OK
        private int _privateField; // OK
    }

    struct aStruct { } // Not OK
    struct AStruct { } // OK

    enum anEnum { } // Not OK
    enum AnEnum { } // OK

    interface anInterface { } // Not OK
    interface IAnInterface { } // OK

    interface Iterable { } // Not OK
    interface IIterable { } // OK
}
