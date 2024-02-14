using System;

namespace csharpmethod
{
    class  Program
    {   
        static void Tisk(int x, int y, float z, char kod)
        {
            Console.WriteLine($"Result is {x} {kod} {y} = {z:F2}");
        }
        static int NumberLoad()
        {
            int x;
            Console.Write("Write number: ");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        static void Main(string[] args)
        {
            int a, b;
            float c;
            char z;

            Console.Write("Calculator\nEnter the char for operation (+, -, *, /): ");

            z = Convert.ToChar(Console.ReadLine());

            switch (z)
            {
                case '+':
                    a = NumberLoad();
                    b = NumberLoad();
                    c = a + b;
                    Tisk(a, b, c, z);
                    break;
                
                case '-':
                    a = NumberLoad();
                    b = NumberLoad();
                    c = a - b;
                    Tisk(a, b, c, z);
                    break;
                
                case '*':
                    a = NumberLoad();
                    b = NumberLoad();
                    c = a * b;
                    Tisk(a, b, c, z);
                    break;
                
                case '/':
                    a = NumberLoad();
                    b = NumberLoad();
                    c = (float)a / b;
                    Tisk(a, b, c, z);
                    break;

                default:
                    Console.WriteLine("Character not found!");
                    break;
            }
            Console.ReadKey();
        }
    }
}