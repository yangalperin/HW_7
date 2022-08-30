// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,7; 5,7; 3,7; 3.


int[,] matr = FillMatrix(3, 4, 1, 10);
PrintMatrix(matr);


int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange, int rightRange)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

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

double sum0 = 0;

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == 0)
        {
            sum0 += matr[i, j];
        }
    }
    
}
double average0 = sum0/matr.GetLength(0);

double sum1 = 0;

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == 1)
        {
            sum1 += matr[i, j];
        }
    }
    
}
double average1 = sum1/matr.GetLength(0);

double sum2 = 0;

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == 2)
        {
            sum2 += matr[i, j];
        }
    }
    
}
double average2 = sum2/matr.GetLength(0);

double sum3 = 0;

for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == 3)
        {
            sum3 += matr[i, j];
        }
    }
    
}
double average3 = sum3/matr.GetLength(0);

Console.WriteLine($" {average0+ " | "+ average1 + " | " + average2 + " | " + average3} ");
