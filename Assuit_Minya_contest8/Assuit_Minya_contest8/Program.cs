
//// Problem B

//int num = int.Parse(Console.ReadLine());
//int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

//Array.Sort(arr);

//long firstnum = 0;
//long secondnum = 0;

//if (arr[0] == 0)
//{
//    arr[0] = arr[1];
//    arr[1] = 0;
//}
//if (arr[num / 2] == 0)
//{
//    arr[num / 2] = arr[(num / 2) + 1];
//    arr[(num / 2) + 1] = 0;
//}

//for(int i = 0; i < num; i++)
//{
//    if(i < num / 2)
//    {
//        firstnum = (firstnum * 10) + arr[i];
//    }
//    else
//        secondnum=(secondnum * 10) + arr[i];
//}

//secondnum = reverse(secondnum);
//Console.WriteLine(firstnum + " " + secondnum);
//Console.WriteLine(secondnum - firstnum);

//static long reverse(long num)
//{
//    long temp = 0;
//    while (num > 0)
//    {
//        temp = (temp * 10) + (num % 10);
//        num /= 10;
//    }
//    return temp;
//}

// ======================================================================>

// Problem D

//int num = int.Parse(Console.ReadLine());

//List<long> numbers = new List<long>();

//for(int y=0; y<num; y++)
//{
//    long[] range = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//    numbers.AddRange(range);
//}

//int count = 0;

//for(int i=0; i<numbers.Count; i++)
//{
//    for(int j=i+1; j<numbers.Count; j++)
//    {
//        for(int k=j+1; k<numbers.Count; k++)
//        {
//            for(int y=k+1; y<numbers.Count; y++)
//            {
//                if (i + j + k + y == 0)
//                    count++;
//            }
//        }
//    }
//}
//Console.WriteLine(count);

// ==========================================================>

//// Problem E

//long[] values = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//for(long y=0; y < values[1]; y++)
//{
//    long sum = 0;
//    long[] index = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
//    for (long i = index[0]-1; i < index[1]; i++)
//        sum += numbers[i];

//    Console.WriteLine(sum);
//}

// ==============================================================>

//// Problem F

//string str = Console.ReadLine();
//double timeA = double.Parse(str.Split(' ')[0]);
//double timeB = double.Parse(str.Split(' ')[1]);
//double timeC = double.Parse(str.Split(' ')[2]);

//double time = (timeA * timeB * timeC) / (((timeA + timeB) * timeC) + (timeA * timeB));

//Console.WriteLine(time.ToString("F9"));

//======================================================>
