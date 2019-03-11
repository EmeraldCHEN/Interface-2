using System;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleInheritanceClass obj = new MultipleInheritanceClass();
            obj.Test();
            obj.Show();

            Interface1 i1 = obj;
            i1.Show();

            Interface2 i2 = obj;
            i2.Show();

            Console.ReadLine();
        }
    }
}
// A class can have one and only one immediate parent class,
// whereas the same class can have any number of interfaces as it's parent 
// i.e. multiple inheritance is supported thru interfaces
