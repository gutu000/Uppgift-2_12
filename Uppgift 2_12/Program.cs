using System;

namespace Uppgift_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string  strNr = Console.ReadLine();
            int nr = Convert.ToInt32(strNr);
            nr = nr + - 1;
            int rr = nr * 500 + 300;
            Console.WriteLine("Okej hur många kilometer ska du köra?");
            String strKm = Console.ReadLine();
            int km = Convert.ToInt32(strKm);
            km = km;
            Console.Write("Så här mycket kommer det att kosta");
            Console.WriteLine(rr + km);

        }
    }
}