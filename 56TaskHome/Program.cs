/*Задача 56: Задайте прямоугольный двумерный массив.
 Напишите программу, которая будет находить строку
  с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/
int[,] InitMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}
void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
(int, int) GetSummOfRaw(int[,] matrix)
{
    int minsum = Int32.MaxValue;
    int index = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            index = index + 1;
        }
        Console.WriteLine($"Сумма элементов {i + 1} строки: {sum}");
    }
    return (minsum, index);
}
int[,] matrix = InitMatrix(3, 4);
PrintArray(matrix);
(int minsum, int index) = GetSummOfRaw(matrix);
Console.WriteLine($"Cтрока с наименьшей суммой {minsum}: {index} -строка");
