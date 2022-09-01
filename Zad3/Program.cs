// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.

Console.WriteLine("Введите m");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matr = new int[m, n];
FillMatrixRandomMatrix(matr);

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

void FillMatrixRandomMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10);
        }
    }
}

PrintMatrix(matr);


for (int j = 0; j < matr.GetLength(1); j++)
{
    double average = 0;
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = sum + matr[i, j];
    }
    average = sum / m;
    Console.Write("Среднее арифметическое столбца: " + average + "; ");
}
Console.WriteLine();
