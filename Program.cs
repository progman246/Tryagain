﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declear variable and initiale to zero 
            int num1=0; int num2=0;

            //Displey Title as the C# Console Calculator 
            Console.WriteLine("---------simple Console calculator by C#-------\r");
            Console.WriteLine("--------------------------------------------------\t");

            //ask the user to type first number 
            Console.WriteLine("Type a Number,then press Enter key");
            num1=Convert.ToInt32(Console.ReadLine());
    
            //ask the user to enter second number 
            Console.WriteLine("Type a Number,then press Enter key");
            num2=Convert.ToInt32(Console.ReadLine());

            //ask the user to chose an action 
            Console.WriteLine("Chose an option from the followning list:");
            Console.WriteLine("\t a -Add");
            Console.WriteLine("\t s -Subtract");
            Console.WriteLine("\t m -Mutiply");
            Console.WriteLine("\t d -Devide");
            Console.WriteLine("\t your Option?");

            //use a switch statement to math 
            switch (Console.ReadLine())
            {
                case "a":
                Console.WriteLine($"Your result:{num1}+{num2}="+(num1+num2));
                break;

                case "s":
                Console.WriteLine($"Your result:{num1}+{num2}="+(num1-num2));
                break;

                case "m":
                Console.WriteLine($"Your result:{num1}+{num2}="+(num1*num2));
                break;

                case "d":
                Console.WriteLine($"Your result:{num1}+{num2}="+(num1/num2));
                break;
            }

            //wait for the user to respond befor closing 
            Console.WriteLine("press any key to close the calculator app");
            Console.ReadLine();
             
        }
    }
}