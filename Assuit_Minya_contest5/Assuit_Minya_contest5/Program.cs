
// Problem J

//double[] numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

//Console.WriteLine((((2 * numbers[0]) + (3 * numbers[1])) * 5 * numbers[2]).ToString("F6"));

// ================================================================================================>

// Problem D

//long num = long.Parse(Console.ReadLine());
//List<long> numbers = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

//foreach(long item in numbers)
//{
//    long count = 0;
//    foreach(long element in numbers)
//    {
//        if (element == item)
//            count++;
//    }
//    if (count % 2 == 0)
//    {
//        Console.WriteLine(item);
//        break;
//    }
//}

// ===============================================>

// Problem A

//int t = int.Parse(Console.ReadLine());
//for (int y = 0; y < t; y++)
//{
//    long bicycle_price = long.Parse(Console.ReadLine());
//    int count = 0;

//    for (int i = 1; i <= bicycle_price; i++)
//    {
//        IEnumerable<int> days = Enumerable.Range(1, i);
//        long sum = days.Sum() * 2;
//        count++;
//        if (sum == bicycle_price || sum > bicycle_price)
//        {
//            Console.WriteLine(count);
//            break;
//        }

//    }
//}

// =========================================================>
//int t = int.Parse(Console.ReadLine());
//for(int y=0; y<t; y++)
//{
//    int num = int.Parse(Console.ReadLine());
//    int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//    int sum = arr.Sum();
//    int product = arr.Aggregate((a, b) => a * b);
//    int plus_sign = 0;
//    foreach(int x in arr)
//    {
//        if (x > 0)
//            plus_sign++;
//    }
//    if (product > 0)
//    {
//        if (sum == 0 || sum > 0)
//            Console.WriteLine(0);
//        else
//        {
//            if (num == 2 || num == 3)
//                Console.WriteLine(num);
//            else if (arr.Length % 2 == 0)
//            {
//                Console.WriteLine((arr.Length / 2) - plus_sign);
//            }
//            else
//            {
//                Console.WriteLine((arr.Length / 2) - plus_sign + 1);
//            }
//        }
//    }
//    else
//    {
//        if(sum == 0 || sum > 0)
//        {
//            Console.WriteLine(1);
//        }
//        else
//        {
//            if (num == 2)
//                Console.WriteLine(num);
//            else if (num == 3)
//                Console.Write(3 - plus_sign);
//            else if (arr.Length % 2 == 0)
//            {
//                Console.WriteLine((arr.Length / 2) - plus_sign);
//            }
//            else
//            {
//                Console.WriteLine((arr.Length / 2) - plus_sign + 1);
//            }
//        }
//    }
//}
// ====================================================================>

////Problem C
//int t = int.Parse(Console.ReadLine());
//for(int y=0; y<t; y++)
//{
//    long x = long.Parse(Console.ReadLine());

//    Console.WriteLine(Math.Pow(2013,x) % 10);
//}

// ===================================================================>

//Problem B

int[] varvalues = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
char[][] farm = new char[varvalues[0]][];

for(int i=0; i<varvalues[0]; i++)
{
    farm[i] = Console.ReadLine().ToCharArray();
}

for(int i=0; i < varvalues[0]; i++)
{
    for (int j = 0; j < varvalues[1]; j++)
        Console.Write(farm[i][j] + " ");
    Console.WriteLine();
}