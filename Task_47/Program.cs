double[,] CreateMatrix(int m, int n)
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = Convert.ToDouble(new Random().Next(-999, 1000)) / 100;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write("{0:F2} \t", matrix[i, k]);
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintMatrix(CreateMatrix(m, n));
