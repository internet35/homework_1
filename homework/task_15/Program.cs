void inputArray(int[] array)
{
for (int i=0; i<array.Length; i++)
  array[i]=new Random().Next();
}
void ReleaseArray(int[]array)
{
    int sumUneven=0;
    for (int i=0; i<array.Length;i++)
    {
        if(i%2!=0)
        sumUneven=sumUneven+array[i];
       
    }
 Console.WriteLine($"сумма элементов,стоящих на нечетных позициях {sumUneven}");

}
Console.Clear();
Console.Write("Введите кол-во элементов массива");
int n=Convert.ToInt32(Console.ReadLine()); 
int[] array= new int[n];
inputArray(array);
Console.WriteLine($"[{string.Join(",",array)}]");
ReleaseArray(array);