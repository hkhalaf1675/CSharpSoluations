// Problem A
string strNum1 = Console.ReadLine();
string strNum2 = Console.ReadLine();

char[] str1CharArr = strNum1.ToArray();
Array.Sort(str1CharArr);

char[] str2CharArr = strNum2.ToArray();
Array.Sort(str2CharArr);

bool check = true;

for(int i=0; i<str1CharArr.Length; i++)
{
    if (str1CharArr[i] != str2CharArr[i])
    {
        check = false;
        break;
    }
}
if(!check || str1CharArr.Length != str2CharArr.Length)
    Console.WriteLine("NO");
else
    Console.WriteLine("YES");
// ======================================================================<><><><><>

