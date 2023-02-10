// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с
// наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int MinRow(int[,] matr)
{
    int minRow = 0;
    int minSum = 1000000;

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum = sum + matr[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    return minRow;
}


System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
System.Console.WriteLine();
PrintMatrix(matrix);
System.Console.WriteLine();
System.Console.WriteLine($"Строка с наименьшей суммой элементов: {MinRow(matrix)}");



