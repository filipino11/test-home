using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Napis cislo:");
            string num01 = "";
            num01 = Console.ReadLine();

            string flip = "";



            for (int i = num01.Length; i > 0; i--)
            {
                flip = flip + num01[i - 1];
            }

            bool res01 = false;

            if (flip == num01)
            {
                res01 = true;
            }

            Console.WriteLine(res01);
        }
    }
}
