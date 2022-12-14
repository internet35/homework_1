Console.Clear();
Console.WriteLine("Введите размер матрица: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
Console.Write("Введите позицию 1 элемента: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите позицию 2 элемента: ");
int b = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10, 99); 
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
 if  (a < 0 || a > m - 1 || b < 0 || b > n - 1)
 Console.WriteLine("такого элемента нет");
 else
Console.WriteLine("Значение элемента матрицы = {0}", matrix[a, b]);