using System;

namespace TryParse__
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            while (!stop)
            {
                int x;

                Console.WriteLine("skriv ett tal: ");

                if (!TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("är inget tal");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("talet är: " + x);
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }

        public static bool TryParse(string s, out int x)
        {
            try
            {
                x = int.Parse(s);
                return true;
            }
            catch (Exception a)
            {
                Console.WriteLine("error: " + a.Message);
                x = 0;
                return false;
            }
        }
    }
}