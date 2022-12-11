Console.Clear();
Console.Write("n= ");
int n = Convert.ToInt32(Console.ReadLine());
int i;
int result=0;
int[] array= new int[n];
for (i = 0; i < n; i ++)
{
    Console.Write ("array[{0}]=",i);
    array[i]=Convert.ToInt32(Console.ReadLine());
    if (array[i]>0)
{
    result=result+1;
}
}

Console.WriteLine($"[{string.Join(",", array)}]");
Console.WriteLine(result);
