Console.Clear();
Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i=10000; i<=n; i++)
{
    if(i%10==0)
    Console.WriteLine("да");
}