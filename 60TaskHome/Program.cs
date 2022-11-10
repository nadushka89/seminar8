/*Задача 60. Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу,
 которая будет построчно выводить массив, добавляя 
 индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

int[,,] RandomMatrix(int m, int n, int l)
{
    int[,,] CreateMatrix = new int[m, n, l];
    Random rndx = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < l; k++)
            {
                CreateMatrix[i, j, k] = rndx.Next(10, 100);
            }
        }
    }
    return CreateMatrix;
}
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write("(" + i + "," + j + " " + k + ")" + matrix[i, j, k] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.Write("Введите количество полей n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стролбцов l: ");
int l = Convert.ToInt32(Console.ReadLine());
int[,,] array = RandomMatrix(m, n, l);
PrintMatrix(array);