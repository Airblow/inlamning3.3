using System;
namespace inlamning3._3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur många hela timmar vill du hyra en bil?");
            short hours = short.Parse(Console.ReadLine());
            int cost = hours * 80;

            if (cost <= 950)
                Console.WriteLine("Det kommer kosta " + cost + " kr");
            else
                Console.WriteLine("Det kommer att kosta 950 kr");

            Console.ReadKey();
        
        }
    
    }

}
