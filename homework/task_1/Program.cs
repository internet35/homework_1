Console.Clear();
Console.Write("Введите 1-е число");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е число");
int m = Convert.ToInt32(Console.ReadLine());
if(n>m)
   { 
      Console.WriteLine("Максимальное значение= "+n);
      Console.WriteLine("Минимальное значение= "+m);
   }
else
   {
      Console.WriteLine("Максимальное значение= "+m);
      Console.WriteLine("Минимальное значение= "+n);
   }

   


