/*Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
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
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SortRows(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < inputMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < inputMatrix.GetLength(1) - 1; k++)
            {
                if (inputMatrix[i, k] < inputMatrix[i, k + 1])
                {
                    int temp = inputMatrix[i, k + 1];
                    inputMatrix[i, k + 1] = inputMatrix[i, k];
                    inputMatrix[i, k] = temp;
                }
            }
        }
    }
}
int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);
Console.WriteLine("Результат: ");
SortRows(resultMatrix);
PrintArray(resultMatrix);

Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов.

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(11);
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
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = GetArray(rows, columns);
PrintArray(resultMatrix);

int SumLineElements(int[,] resultMatrix, int i)
{
    int sum = resultMatrix[i, 0];
    for (int j = 1; j < resultMatrix.GetLength(1); j++)
    {
        sum += resultMatrix[i, j];
    }
    return sum;
}
int minSumLine = 0;
int sum = SumLineElements(resultMatrix, 0);
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(resultMatrix, i);
    if (sum > tempSumLine)
    {
        sum = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"rows{minSumLine + 1} - строка с наименьшей суммой {sum} элементов");
*/
