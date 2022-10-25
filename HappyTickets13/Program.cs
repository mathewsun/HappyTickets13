
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
            ////char[] arAlphabet = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            //int n = 4;
            //char[] arBuffer = new char[n];

            //StringBuilder stringBuilder = new StringBuilder((int)Math.Pow(arAlphabet.Length, n) * (n + 2));

            //RecursionGenerateCombinationsToFile(arAlphabet, arBuffer, 0, stringBuilder);
            //var list = stringBuilder.ToString().Replace("\r", "").Split('\n').Where(x => x != "").ToArray();

            //var listSum = list.Select(x => (x, Sum(x))).ToArray();

            //var list0Sum = listSum.Where(x => x.x[0] == '0').ToArray();


            //// var list0Sum = list0.Select(x => (x, Sum(x))).ToList();
            //int count = 0;
            //foreach (var x in arAlphabet)
            //{
            //    foreach (var q in list0Sum)
            //    {
            //        var co = listSum.Where(y => q.Item2 == y.Item2).ToList();
            //        Console.WriteLine($"{q.x} {co.Count()}");
            //        foreach (var c in co)
            //        {
            //            count++;
            //            //Console.WriteLine($"{q.x} {x} {c.x}");
            //        }
            //    }
            //}

            //максимальное справа
            var maxSum = Sum("CCCCCC");

            var maxSums = new int[maxSum + 1];

            //for (int a = 0; a < 1; a++)
            for (int a = 0; a < numbers.Count(); a++)
            {
                for (int b = 0; b < numbers.Count(); b++)
                {
                    for (int c = 0; c < numbers.Count(); c++)
                    {
                        for (int d = 0; d < numbers.Count(); d++)
                        {
                            for (int e = 0; e < numbers.Count(); e++)
                            {
                                for (int f = 0; f < numbers.Count(); f++)
                                {
                                    ++maxSums[a + b + c + d + e + f];
                                }
                            }
                        }
                    }
                }
            }

            long result = 0;

            //максимальное слева
            var x = Sum("CCCCCC");
            //for (int i = 0; i < maxSums.Count(); ++i)
            //{
            //    if (x <= maxSums[i])
            //    {
            //        result += maxSums[i] * maxSums[i];
            //    }
            //}
            //3597455855


            for (int i = 0; i < maxSums.Count(); ++i)
            {
                result += maxSums[i] * maxSums[i];
            }
            //

            //282160467 - количество комдинаций 0CCCCC
            //3597463083 - количество комдинаций CCCCCC

        }

        private static void RecursionGenerateCombinationsToFile(char[] arAlphabet, char[] arBuffer, int order,
                                                                StringBuilder stringBuilder)
        {
            if (order < arBuffer.Length)
                for (int i = 0; i < arAlphabet.Length; i++)
                {
                    arBuffer[order] = arAlphabet[i];
                    RecursionGenerateCombinationsToFile(arAlphabet, arBuffer, order + 1, stringBuilder);
                }
            else
            {
                for (int i = 0; i < arBuffer.Length; i++)
                    stringBuilder.Append(arBuffer[i]);
                stringBuilder.AppendLine();
            }
        }

        public static int Sum(string str)
        {
            int x = 0;
            foreach (char c in str)
            {
                x += ToInt(c.ToString());
            }

            return x;
        }

        public static int ToInt(string str)
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
    }
}





