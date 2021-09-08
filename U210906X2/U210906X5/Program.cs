using System;

namespace U210906X5
{
    class Program
    {
        static void Main(string[] args)
        {
            string mening = "";
            while (true)
            {
                Console.WriteLine("Skriv ett ord:");
                string ord = Console.ReadLine();

                if (ord == "avsluta"|| ord == "Avsluta"|| ord == "AVSLUTA")
                {
                    break;
                }
                mening = mening + " " + ord;
            }
            Console.WriteLine($"Din mening just nu är: {mening}.");
        }
        
    }
}
