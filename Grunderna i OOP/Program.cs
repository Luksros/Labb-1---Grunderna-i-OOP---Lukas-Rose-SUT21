using System;

namespace Grunderna_i_OOP
    //LUKAS ROSE
    //SUT21
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle five = new Circle(5);
            Circle six = new Circle(6);
            five.CalculateAll();
            six.CalculateAll();

            Console.WriteLine("Skriv in en egen radie på en cirkel/ett klot: ");
            int userRadius;
            while (!int.TryParse(Console.ReadLine(), out userRadius))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Ogilting input. ");
                Console.ResetColor();
                Console.Write("Skriv in radien som ett heltal: ");
            }

            Circle userCircle = new Circle(userRadius);
            userCircle.CalculateAll();

            Console.ReadLine(); 
        }
    }
}
