using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HappyTickets13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C' };
            //char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; 

            var maxSum = Sum("CCCCCC");
            //var maxSum = Sum("9999"); 

            //индекс массива - сумма чисел, значение ячейки - количество комбинаций 
            long[] maxSums = new long[maxSum + 1];
            var count = numbers.Count();

            for (int a = 0; a < count; a++)
            {
                for (int b = 0; b < count; b++)
                {
                    for (int c = 0; c < count; c++)
                    {
                        for (int d = 0; d < count; d++)
                        {
                            for (int e = 0; e < count; e++)
                            {
                                for (int f = 0; f < count; f++)
                                {
                                    var index = a + b + c + d + e + f; 
                                    ++maxSums[index];
                                }
                            }
                        }
                    }
                }
            }

            long result = 0;

            var x = Sum("CCCCCC");
            //var x = Sum("9999"); 
            for (int i = 0; i < maxSums.Count(); ++i)
            {
                result += maxSums[i] * maxSums[i];
            }
      
            Console.WriteLine($"Actual result:\n{result}");

            //Умножаем еще на 1, потому что посередине есть цифра, которая не учитывается при подсчёте комбинаций
            Console.WriteLine($"Actual result * 13:\n{result * 13}");

            //для 13 значных 13-теричных счастливых билетиков получаем 46767020079 счастливых билетиков
        }
        public static int Sum(string str)
        {
            int x = 0;
            foreach (char c in str)
            {
                x += ConvertToInt13(c.ToString());
            }

            return x;
        }

        public static int ConvertToInt13(string str)
        {
            if (str == "A")
            {
                return 10;
            }
            if (str == "B")
            {
                return 11;
            }
            if (str == "C")
            {
                return 12;
            }

            return int.Parse(str);
        }

        //public static int ConvertToInt10(string str)
        //{
        //    return int.Parse(str);
        //}
    }
}