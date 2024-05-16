using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************\n\nThis is a Calculator\n\n********************\n\nChoose the operation\n\n********************\n");
            Console.WriteLine("1)Add\n2)Subtract\n3)Multiply\n4)Divide\n5)EXIT\n\n********************\n");
            int operation = Convert.ToInt32(Console.ReadLine());
            Double n1, n2, n3=0;


            if (operation == 1)
            {
                Console.WriteLine("Enter the first number\n");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number\n");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1 + n2;
                Console.WriteLine("The sum of these numbers is " + n3 + "\n");
            }
            else if (operation == 2)
            {
                Console.WriteLine("Enter the first number\n");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number\n");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1 - n2;
                Console.WriteLine("The difference of these numbers is " + n3 + "\n");
            }
            else if (operation == 3)
            {
                Console.WriteLine("Enter the first number\n");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number\n");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1 * n2;
                Console.WriteLine("The product of these numbers is " + n3 + "\n");
            }
            else if (operation == 4)
            {
                Console.WriteLine("Enter the first number\n");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number\n");
                n2 = Convert.ToInt32(Console.ReadLine());
                n3 = n1 / n2;
                Console.WriteLine("The quotient of these numbers is " + n3 + "\n");
            }
            else
            {
                Console.WriteLine("Invalid input. Please try again!");
            }




        }
    }
}

