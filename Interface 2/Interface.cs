using System;

namespace Interface_2
{
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    class MultipleInheritanceClass : Interface1, Interface2
    {
        public void Show() // Implement interface
        {
            Console.WriteLine("Declared in interface2 and implemented in child class.");
        }

        public void Test()
        {
            Console.WriteLine("Interface method implemented in child class.");
        }

        void Interface1.Show() // Implement interface explicitly
        {
            Console.WriteLine("Declared in interface1 and implemented in child class.");
        }
    }
}
