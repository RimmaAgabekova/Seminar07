// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

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

Console.WriteLine("Введите строку");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine("Введите столбец:");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.WriteLine();

GetPosition(matrix); 

void GetPosition(int[,] matr)
{
    int result = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(pos1 == i && pos2 == j)
            {
                result = matr[i,j];
                break;
            }
        }
        if (Convert.ToBoolean(result))
        {
            break;
        }
    }

    if (Convert.ToBoolean(result)) 
    {
        Console.Write("Значение элемента массива = {0}", matr[pos1, pos2]);
    }
    else
    {
        Console.Write($"{pos1+1} - {pos2+1} -> Элемент не существует");
    }  
} 
