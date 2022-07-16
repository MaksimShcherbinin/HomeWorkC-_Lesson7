int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            matrix[i, k] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix.GetLength(1); k++)
        {
            Console.Write(matrix[i, k] + " \t");
        }
        Console.WriteLine();
    }
}

void AverageCol(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double average = 0;
        for (int k = 0; k < matrix.GetLength(0); k++)
        {
            average = average + matrix[k, i];
        }
        average = average / matrix.GetLength(0);
        Console.Write("{0:f2} \t", average);
    }
}

Console.Write("Введите кол-во строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);
AverageCol(matrix);
