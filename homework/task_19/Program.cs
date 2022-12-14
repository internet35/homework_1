void InputMatrix(double[, ] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)

    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(new Random().NextDouble()*(20-10)+10,2);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
 string [] coord = Console.ReadLine().Split(" ");
int row = int.Parse(coord[0]);
int col = int.Parse(coord[1]);
double[,] matrix = new double[row, col];
InputMatrix(matrix);