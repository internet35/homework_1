void inputArray(double[] array)
{
for (int i=0; i<array.Length; i++)
  array[i]=new Random().Next(0,100);
}
void ReleaseArray(double[]array)
{
    double min=array[0];
    double max=array[0];
    for (int i=0; i<array.Length;i++)
    {
        if(array[i]<min)
        min=array[i];
        else if (array[i]>max)
        max=array[i];
       
    }
 Console.WriteLine($"разница между максимальным и минимальным элементов массива {max-min}");

}
Console.Clear();
Console.Write("Введите кол-во элементов массива");
int n=Convert.ToInt32(Console.ReadLine()); 
double[] array= new double[n];
inputArray(array);
Console.WriteLine($"[{string.Join(",",array)}]");
ReleaseArray(array);
