Console.Clear();
Console.Write("Введите 1-е число");
int n = Convert.ToInt32(Console.ReadLine());

while(n>=1000)
{
    n=n/10;    
}  

Console.Write(n%10); 

if  (n<100) Console.Write("Нет третьего числа");






