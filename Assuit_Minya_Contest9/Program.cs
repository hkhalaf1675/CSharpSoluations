//// Probem B

//int t = int.Parse(Console.ReadLine());
//for(int y =0; y<t; y++)
//{
//    string str = Console.ReadLine();

//    long numM = Convert.ToInt64(str.Split(' ')[0]);
//    long numN = Convert.ToInt64(str.Split(' ')[1]);

//    int counter = 0;

//    for (numM = numM; numM > 0; numM = numM - numN)
//        counter++;

//    Console.WriteLine(counter);
//}

// ====================================================>

//// Problem C

//int t = Convert.ToInt32(Console.ReadLine());
//for(int y=0; y<t; y++)
//{
//    long num = Convert.ToInt64(Console.ReadLine());

//    char[] chars = Console.ReadLine().ToCharArray();
//    int counter = 0;
//    foreach(char c in chars)
//    {
//        if (c == 'A' || c == 'B')
//            counter++;
//    }
//    Console.WriteLine(counter);
//}

// =========================================>

//Problem E
string str = Console.ReadLine();
long x = Convert.ToInt64(str.Split(' ')[0]);
long y = Convert.ToInt64(str.Split(' ')[1]);

Console.WriteLine(x+(y/2));