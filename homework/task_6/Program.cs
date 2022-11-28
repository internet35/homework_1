Console.Clear();
Console.Write("Введите 1-е число");
int n = Convert.ToInt32(Console.ReadLine());
if (n<100) 

    Console.Write("Нет третьего числа");  
else
{
while(n>=1000)
n=n/10;     
Console.WriteLine(n%10); 
}








