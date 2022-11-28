Console.Clear();
Console.Write("Введите цифру,обозначающую день недели");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 6 || n == 7) 
{
  Console.WriteLine("(этот день выходной) - да");
}
  else if (n < 1 || n > 7) 
{
    Console.WriteLine("вы ошиблись, это не день недели");
}
  else Console.WriteLine("(этот день не выходной) - нет");