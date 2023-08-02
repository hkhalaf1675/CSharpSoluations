//// Palindrome

//using System.ComponentModel;

//static bool palindrome(long num)
//{
//    long temp = num;
//    long pali = 0;
//    while (temp != 0)
//    {
//        pali = (pali * 10) + (temp % 10);
//        temp = temp / 10;
//    }
//    if (pali == num)
//        return true;
//    else
//        return false;
//}

//int t = int.Parse(Console.ReadLine());
//for (int y = 0; y < t; y++)
//{
//    long num = long.Parse(Console.ReadLine());
//    {
//        long i = 10000000;
//        bool f = false;
//        if (num % 10 == 0)
//            f = false;
//        else
//        {
//            for (i = i ; i < Math.Pow(10, 9); i++)
//            {
//                if (i % num == 0)
//                {
//                    if (palindrome(i))
//                    {
//                        Console.WriteLine(i);
//                        f = true;
//                        break;
//                    }
//                    else
//                    {

//                    }
//                }
//            }
//        }
//        if (f == false)
//            Console.WriteLine(-1);
//    }
//}

// ====================================================>

// Problem C

//int t = int.Parse(Console.ReadLine());
//for(int y=0; y<t; y++)
//{
//    long[] values = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

//    long tasty_cake = 0;

//    if (values[2] > values[1])
//    {
//        values[2] = values[2] - values[1];
//        tasty_cake += values[1] * 2;

//        if (values[2] > values[0])
//        {
//            tasty_cake += values[0] + 1;
//        }
//        else
//        {
//            tasty_cake += values[2];
//        }
//    }
//    else
//    {
//        tasty_cake = values[1] + values[2];
//    }
//    Console.WriteLine(tasty_cake);
//}

// ================================================>

// Problem E

//int t = int.Parse(Console.ReadLine());
//for (int y = 0; y < t; y++)
//{
//    long num = long.Parse(Console.ReadLine());
//    long[] numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

//    long two_divisor = 0;
//    long three_divisor = 0;

//    foreach (long x in numbers)
//    {
//        int divisor = 2;
//        if (x == 1 || x == 0)
//            divisor = 1;

//        for (long i = 2; i < x; i++)
//        {
//            if (x % i == 0)
//                divisor++;
//            if (divisor > 3)
//                break;
//        }
//        if (divisor == 2)
//            two_divisor++;
//        else if (divisor == 3)
//            three_divisor++;
//    }
//    long min = Math.Abs(two_divisor - three_divisor);
//    if (min == 0)
//        min = 1;

//    long pair_count = 1;

//    for (long i = min; i <= Math.Max(two_divisor, three_divisor); i++)
//        pair_count = pair_count * i;

//    if (two_divisor == 0 || three_divisor == 0)
//        pair_count = 0;

//    Console.WriteLine(pair_count);
//}

// ========================================================================>

// Round 881
// Problem A
//int t = int.Parse(Console.ReadLine());
//for (int y=0; y < t; y++)
//{
//    int n = int.Parse(Console.ReadLine());
//    int[] numbers=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//    Array.Sort(numbers);

//    int colors = n / 2;
//    int cost = 0;
//    int head = 0;
//    int tail = n - 1;

//    while (colors > 0)
//    {
//        cost += numbers[tail] - numbers[head];
//        head++;
//        tail--;
//        colors--;
//    }

//    Console.WriteLine(cost);
//}

// =======================================================>

// Problem c
//int t = int.Parse(Console.ReadLine());
//for(int y=0; y<t; y++)
//{
//    long num = long.Parse(Console.ReadLine());
//    long sum = 0;
//    while(num > 0)
//    {
//        sum += num;
//        if (num % 2 == 0)
//            num /= 2;
//        else
//            num = (num - 1) / 2;
//    }
//    Console.WriteLine(sum);
//}

// ===========================================================>>

// Problem F

//int t = int.Parse(Console.ReadLine());
//for(int y=0; y<t; y++)
//{
//    long[] values = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//    long pair_count = 0;

//    for(long i=1; i <= values[0]; i++)
//    {
//        for(long j=1; j <= values[1]; j++)
//        {
//            if ((i + j) % values[2] == 0)
//                pair_count++;
//        }
//    }
//    Console.WriteLine(pair_count);
//}

// ====================================================>

// Problem G

//using System.Numerics;

//int t = int.Parse(Console.ReadLine());

//for (int y = 0; y < t; y++)
//{
//    string str = Console.ReadLine();

//    BigInteger num = 0;
//    long repeat_count = 0;

//    for(int i = 0; i<str.Length; i++)
//    {
//        repeat_count = str.Count(n => n == str[i]);

//        if (repeat_count < 10)
//            num = (num * 10) + repeat_count;
//        else if (repeat_count < 100 && repeat_count >= 10)
//            num = (num * 100) + repeat_count;
//        else if (repeat_count < 1000 && repeat_count >= 100)
//            num = (num * 1000) + repeat_count;
//        else
//            num = (num * 10000) + repeat_count;
//    }

//    if (palindrome(num))
//        Console.WriteLine("YES");
//    else
//        Console.WriteLine("NO");
//}

//static bool palindrome(BigInteger num)
//{
//    BigInteger temp = num;
//    BigInteger pali = 0;
//    while (temp != 0)
//    {
//        pali = (pali * 10) + (temp % 10);
//        temp = temp / 10;
//    }
//    if (pali == num)
//        return true;
//    else
//        return false;
//}

// =================================================>

//PProblem I

int t = int.Parse(Console.ReadLine());
for(int y=0; y<t; y++)
{
    int num = int.Parse(Console.ReadLine());
    long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

    bool f = false;
    for(int i =0; i<num; i++)
    {
        for(int j=i+1; j<num; j++)
        {
            for(int k=j+1; k<num; k++)
            {
                if ((arr[i] + arr[j] + arr[k]) % 2 == 0)
                {
                    Console.WriteLine("Yes");
                    f = true;
                    break;
                }
                if (f == true)
                    break;
            }
            if (f == true)
                break;
        }
    }
    if (f == false)
        Console.WriteLine("NO");
}