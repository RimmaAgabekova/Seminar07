// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

Console.WriteLine("Введите количество строк матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

double[,] matrix = new double[m, n];
PrintArray(matrix);

void PrintArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        matr[i,j] = Convert.ToDouble(new Random().Next(-100, 1000)/10.0);
         Console.Write($"{matr[i, j]} ");
         }
    Console.WriteLine ();
    }
}

