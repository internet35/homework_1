Console.Clear();
Console.Write("Введите 1-е число");
int n = Convert.ToInt32(Console.ReadLine());
if((n % 2)==0)
   { 
      Console.WriteLine("число четное");
   }
else
   {
      Console.WriteLine("число нечетное");
   }