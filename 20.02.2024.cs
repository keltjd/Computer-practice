using System.Runtime.Intrinsics.X86;

int first(int[] args)
{
    int cnt = 1;
    int m = 0;
    int i = 0;
    while (args[i] != 0)
    {
        if (args[i] == args[i + 1]) cnt += 1;
        else
        {
            if (cnt > m) m = cnt;
            cnt = 0;
        }
        i++;
    }
    return m;
}

int second(int a)
{
    int r = 0;
    for (int i = 2; i < a; i++)
    {
        if ((a / i) * i == a) return i;
    }
    return 0;
}

bool sixth(int a)
{
    string b = Convert.ToString(a);
    for(int i = 0; i < b.Length - 1; i++)
    {
        if (b[i] != b[i + 1]) return false;
    }
    return true;
}
//int a = Convert.ToInt32(Console.ReadLine());
//int[] numbers = new int[a];
//for (int i = 0; i < a; i++)
//{
//    numbers[i] = Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine(first(numbers));

//int a = 1121;
//Console.WriteLine(sixth(a));

