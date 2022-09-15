using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            Console.ReadLine();
            Console.WriteLine("Okej och hur många kilometer?");
            string dagar = Console.ReadLine();
            int dagtotal = 500;
            int kilometerpris = 40;
            int start = 300;
            int allt = dagtotal + kilometerpris + start;

            Console.WriteLine("Okej, det kommer kosta totalt " + allt);
            // hej
            
        }
    }
}