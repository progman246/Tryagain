using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator1 c1=new Calculator1();
            Console.WriteLine(c1.add(1,2).ToString());
        }
    }
}