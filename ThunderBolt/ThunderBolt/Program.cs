
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThunderBolt
{
    class Program
    {
        static void Main(string[] args)
        {
            int testNum = int.Parse(Console.ReadLine());
            int[] outputs = new int[testNum];

            for (int i = 0; i < testNum; i++)
            {
                string taken = Console.ReadLine();
                int start = int.Parse(taken.Split(' ')[0]);
                int end = int.Parse(taken.Split(' ')[1]);

                for (int j = start; j <= end; j++)
                {
                    if ((isPrime(j)) && isPrime(sumDigits(j)))
                        outputs[i] += 1;
                }
            }

            for (int i = 0; i < testNum; i++)
                Console.WriteLine(outputs[i]);

            Console.ReadKey();


        }
        // is prime method
        static public Boolean isPrime(int num)
        {
            if (num < 2) return false;
            if (num % 2 == 0) return (num == 2);
            int root = (int)Math.Sqrt((double)num);

            for (int a = 3; a <= root; a += 2)
                if (num % a == 0)
                    return false;

            return true;
        }
        // sum of digit methos
        static public int sumDigits(int num)
        {
            string digits = num.ToString();
            int sum = 0;
            for (int j = 0; j < digits.Length; j++)
            {
                sum += (int)(digits[j] - '0');
            }
            return sum;
        }
    }
}
