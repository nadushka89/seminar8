/*Задача 62. Напишите программу, которая 
заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine()); // так как квалратная матрица m=n(size)
int[,] Matrix = new int[size, size];
int number = 1;
int i = 0;
int j = 0;
while (number <= size * size)
{
    Matrix[i, j] = number;
    if (i <= j + 1 && i + j < size - 1)
        ++j;                         // вправо
    else if (i < j && i + j >= size - 1)
        ++i;                         // вниз
    else if (i >= j && i + j > size - 1)
        --j;                         // влево
    else
        --i;                         // вверх
    ++number;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j]<10)
            {
                Console.Write(array[i, j] + "  "); // для ровности (до 10 =2 пробела после)
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
PrintArray(Matrix);