int sum(int m, int n)
{
    if (n==m)
    return m;
    return sum(m,n-1)+n;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sum(m,n));
