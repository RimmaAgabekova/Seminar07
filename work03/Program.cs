// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк матрицы:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы:");
int n = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine();

int[,] matrix = new int[m, n];
PrintArray(matrix);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        matr[i,j] = new Random().Next(0, 20);
         Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
Console.WriteLine();

GetSum(matrix);

void GetSum(int[,] matr)
{
    double sum = 0;
    double[] result = new double[matr.GetLength(1)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[j, i];
            result[i] = Math.Round(sum/matr.GetLength(0), 1);
        }
    }
    Console.WriteLine("Ср. арифметическое столбцов: " + String.Join("; ", result) + ".");
} 



