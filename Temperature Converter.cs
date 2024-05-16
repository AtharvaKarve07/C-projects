using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature converter");
            Console.WriteLine("************************************");
            Console.WriteLine("Enter 'celcuis' to convert celcuis to\nfarenheit or else enter 'Farenheit' to\nconvert farenheit to celcuis");
            Console.WriteLine("************************************");
            string choice = Console.ReadLine();

            if (choice == "celcuis")
            {
                Console.WriteLine("Enter the celcuise temperature:-");
                float celcuise = float.Parse(Console.ReadLine());
                float farenheit = (celcuise * 1.8f) + 32;
                Console.WriteLine("The temperatur in farenheit is " + farenheit);
                Console.WriteLine("Thank you!!");
            }
            else
            {
                Console.WriteLine("Enter the farenheit temperature:-");
                float farenheit = float.Parse(Console.ReadLine());
                float celcuise = (farenheit - 32) / 1.8f;
                Console.WriteLine("The temperature in celcius is " + celcuise);
            }
        }
    }
}
