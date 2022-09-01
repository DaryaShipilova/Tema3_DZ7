// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4          1 7 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс номера строки: ");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс номера столбца: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());

int[,] matr = FillMatrix(m, n, -10, 10);
PrintMatrix(matr);

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] FillMatrix(int rowsCount, int columnCount, int leftRange, int righttRange)
{
    int[,] matrix = new int[rowsCount, columnCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, righttRange);
        }
    }
    return matrix;
}

if (indexRows > m - 1 || indexRows < 0 || indexColumn > n - 1 || indexColumn < 0)
{
    Console.WriteLine("Числа с такими индексами нет в массиве");
}
else
{
    Console.WriteLine($"значение элемента {indexRows} строки и {indexColumn} столбца равно {matr[indexRows, indexColumn]}");
}

