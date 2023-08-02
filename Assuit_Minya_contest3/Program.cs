using System;
using System.Collections.Generic;
using System.Linq;

namespace Assuit_Minya_contest3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Problem D
            //int day = Convert.ToInt32(Console.ReadLine());

            //switch (day)
            //{
            //    case 22:
            //        Console.WriteLine("Christmas Eve Eve Eve");
            //        break;
            //    case 23:
            //        Console.WriteLine("Christmas Eve Eve");
            //        break;
            //    case 24:
            //        Console.WriteLine("Christmas Eve");
            //        break;
            //    case 25:
            //        Console.WriteLine("Christmas");
            //        break;
            //}

            // =============================================================>

            // Problem F

            //double num = double.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Sqrt(num));

            // =============================================================>

            // Problem H

            //string input = Console.ReadLine();
            //int digit_count = input.Length;

            //Console.WriteLine(digit_count);

            //=============================================================>

            // Problem C
            //long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            //long numofoperation = long.Parse(Console.ReadLine());

            //long[] temp = new long[5];

            //for(long i=0; i<numofoperation; i++)
            //{
            //    for(int j=0; j<4; j++)
            //    {
            //        temp[j] = numbers[j + 1];
            //    }
            //    temp[4] = numbers[0];
            //    numbers = temp;
            //}
            //foreach (long x in temp)
            //{
            //    Console.Write(x + " ");
            //}

            // ==========================================================>

            //long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            //long numofoperation = long.Parse(Console.ReadLine());

            //Queue<long> q = new Queue<long>();
            //foreach (long x in numbers)
            //    q.Enqueue(x);
            //for(long i =0; i<numofoperation; i++)
            //{
            //    long temp = q.Dequeue();
            //    q.Enqueue(temp);
            //}
            //foreach(long x in q)
            //{
            //    Console.Write(x + " ");
            //}

            // =====================================================================>

            //Problem I

            //string str = Console.ReadLine();
            //int n = Convert.ToInt32(str.Split(' ')[0]);
            //int c = Convert.ToInt32(str.Split(' ')[1]);
            //int d = Convert.ToInt32(str.Split(' ')[2]);

            //int count = 0;
            //for(int i=1; i<=n; i++)
            //{
            //    for (int j = 1; j <= n; j++)
            //    {
            //        if ((i + j) % c == d)
            //            count++;
            //    }
                    
            //}
            //Console.WriteLine(count);

            // =============================================================>

            //Problem A

            int num = Convert.ToInt32(Console.ReadLine());

            int[] arrnumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] str = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Array.Sort(arrnumbers);

            foreach (int x in arrnumbers)
                Console.Write(x + " ");
            Console.WriteLine();

            switch(str[0])
            {
                case 1:
                    Console.WriteLine(arrnumbers[str[1]-1] + arrnumbers[str[2]-1]);
                    break;
                case 2:
                    Console.WriteLine(arrnumbers[str[1]-1] - arrnumbers[str[2]-1]);
                    break;
                case 3:
                    Console.WriteLine(arrnumbers[str[1]-1] * arrnumbers[str[2]-1]);
                    break;
            }
        }
    }
}
