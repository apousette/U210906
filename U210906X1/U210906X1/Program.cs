using System;

namespace U210906X1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en mening:");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split();
            Console.WriteLine(words.Length);

            foreach (var word in words)
            {
                Console.WriteLine($"{word} ({words.Length})");
            }

        }
    }
}
