//Problem A

//long num = long.Parse(Console.ReadLine());

//long[] arrnumbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

//long y = Convert.ToInt32(Console.ReadLine());

//long count = 0;

//foreach(long x in arrnumbers)
//{
//    if ((x + y) % 3 == 0)
//        count++;
//}
//Console.WriteLine(count);
// ===================================================================>

//Problem B

//double[] ab = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//double c = Math.Sqrt((ab[0] * ab[0]) + (ab[1] * ab[1]));

//Console.WriteLine(((c / 2 * c / 2 * 3.14159) / 2).ToString("F4"));

// ========================================================================>

// Problem C

//int[] range = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//long sum = 0;

//for(int i = range.Min(); i <= range.Max(); i++)
//{
//    if (i % 2 != 0)
//        sum += i;
//}
//Console.WriteLine(sum);

// ======================================================>

//Problem D

//int num = int.Parse(Console.ReadLine());
//long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

//List<long> lucky_numbers = new List<long>();
//int count = 0;

//foreach(long i in numbers)
//{
//    long x = i;
//    bool f = false;
//    while(x != 0)
//    {
//        if (x % 10 != 7 && x % 10 != 4)
//        {
//            f = true;
//            break;
//        }
//        x = x / 10;
//    }
//    if (f == false && i != 0)
//    {
//        count++;
//        lucky_numbers.Add(i);
//    }
//}
//Console.WriteLine(count);
//foreach (long x in lucky_numbers)
//    Console.Write(x + " ");

// =============================================>

// Problem H

//int num = int.Parse(Console.ReadLine());
//int[] numbers = new int[num];
//for(int i=0; i<num; i++)
//{
//    numbers[i] = int.Parse(Console.ReadLine());
//}

//foreach(int x in numbers)
//{
//    int active_diotes = 0;
//    int i = x;
//    if (i == 0)
//        active_diotes += 6;
//    while (i != 0)
//    {
//        switch (i % 10)
//        {
//            case 0:
//                active_diotes += 6;
//                break;
//            case 1:
//                active_diotes += 2;
//                break;
//            case 2:
//                active_diotes += 5;
//                break;
//            case 3:
//                active_diotes += 5;
//                break;
//            case 4:
//                active_diotes += 4;
//                break;
//            case 5:
//                active_diotes += 5;
//                break;
//            case 6:
//                active_diotes += 6;
//                break;
//            case 7:
//                active_diotes += 3;
//                break;
//            case 8:
//                active_diotes += 7;
//                break;
//            case 9:
//                active_diotes += 6;
//                break;
//        }
//        i = i / 10;
//    }
//    Console.WriteLine(active_diotes);
//}

// =====================================================>

// Problem G

//int[] numb = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//int count = 0;
//for(int i = numb[1]; i <= numb[2]; i++)
//{
//    for(int j=i+1; j <= numb[2]; j++)
//    {
//        for(int y=j+1; y <= numb[2]; y++)
//        {
//            if (i + j + y == numb[0])
//                count++;
//        }
//    }
//}
//Console.WriteLine(count);

// =========================================>

//Problem I
using System.Numerics;

BigInteger num = BigInteger.Parse(Console.ReadLine());
BigInteger[] numbers = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

for(BigInteger i =numbers.Min(); i<=numbers.Max()+1; i++)
{
    BigInteger[] temp = Enumerable.Repeat(i, numbers.Length).ToArray();
    if (temp.Aggregate((a,b)=>a*b) > numbers.Aggregate((a,b)=>a*b))
    {
        Console.WriteLine(i);
        break;
    }
}

//===============================================>

