Console.Clear();
Console.Write("n= ");
int n = Convert.ToInt32(Console.ReadLine());
int i;
int[] array= new int[8];
for (i = 0; i < n; i ++)
{
    Console.Write ("array[{0}]=",i);
    array[i]=Convert.ToInt32(Console.ReadLine());

}

Console.WriteLine($"[{string.Join(",", array)}]");
