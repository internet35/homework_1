Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32((Console.ReadLine()));
Console.Write("Введите второе число: ");
int m = Convert.ToInt32((Console.ReadLine()));
int i; 
int result =1;

for (i = 1; i <= m; i ++)
{
    result = result*m;

}
 Console.Write(result);