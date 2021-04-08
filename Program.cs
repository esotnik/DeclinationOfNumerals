using System;

namespace DeclinationOfNumerals
{
    // метод, склоняющий существительное «рублей» следующее за указанным числительным.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(PluralizeRubles(10));
            Console.WriteLine(PluralizeRubles(1));
            Console.WriteLine(PluralizeRubles(24));
        }

        public static string PluralizeRubles(int count)
        {
            string s = count.ToString();
            int k = int.Parse(s.Substring(s.Length - 1));
            int i = 0;
            if (count > 10) i = int.Parse(s.Substring(s.Length - 2, 1));
            if (i == 1) return "рублей";
            if (k == 1) return "рубль";
            else if (k == 2 || k == 3 || k == 4) return "рубля";
            else return "рублей";
        }
    }
}
