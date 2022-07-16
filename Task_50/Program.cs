void SearchMatrix(int[,] matrix, int line, int col)
{
    if (line <= matrix.GetLength(0) 
        && col <= matrix.GetLength(1)
        && line >= 1
        && col >= 1)
        Console.WriteLine("Искомый элемент: {0}", matrix[line - 1, col - 1]);
    else Console.WriteLine("Элемента в строке {0} и столбце {1} не существует.", line, col);
}

Console.Write("Введите строчку искомого элемента: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбик искомого элемента: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[,]
                { { 1, 2, 3, 4, 5 }
                , { 6, 7, 8, 9, 10 }
                , { 11, 12, 13, 14, 15 }
                , { 16, 17, 18, 19, 20 }
                , { 21, 22, 23, 24, 25}};

SearchMatrix(matrix, line, col);
