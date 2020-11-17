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

                if (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("inget tal");
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
            x = int.Parse(s);
            return true;

            /*
            try
            {
                x = int.Parse(s);
                return true;
            }
            catch
            {
                x = 0;
                return false;
            }
            */
        }
    }
}
