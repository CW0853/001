using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1111410002_劉昀叡032
{
    internal class Program
    {
        public static string Roman(int num)
        {
            if (num < 0 || num > 3999)
                throw new ArgumentOutOfRangeException(nameof(num), "請輸入1~3999的整數。");
            if (num < 1)
                return string.Empty;
            if (num >= 1000)
                return "M" + Roman(num - 1000);
            if (num >= 900)
                return "CM" + Roman(num - 900);
            if (num >= 500)
                return "D" + Roman(num - 500);
            if (num >= 400)
                return "CD" + Roman(num - 400);
            if (num >= 100)
                return "C" + Roman(num - 100);
            if (num >= 90)
                return "XC" + Roman(num - 90);
            if (num >= 50)
                return "L" + Roman(num - 50);
            if (num >= 40)
                return "XL" + Roman(num - 40);
            if (num >= 10)
                return "X" + Roman(num - 10);
            if (num >= 9)
                return "IX" + Roman(num - 9);
            if (num >= 5)
                return "V" + Roman(num - 5);
            if (num >= 4)
                return "IV" + Roman(num - 4);

            return "I" + Roman(num - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入整數:");
            int input = int.Parse(Console.ReadLine());

            string romannum = Roman(input);
            Console.WriteLine($"羅馬數字為: {romannum}");
        }
    }
}
