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

Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.


Console.Write("Введите количество строк для первой матрицы: ");
int firstMatrixRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int firstMatrixColumns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество строк для второй матрицы: ");
int secondMatrixRows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов для первой матрицы: ");
int secondMatrixColumns = Convert.ToInt32(Console.ReadLine());

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
int[,] firstMatrix = GetArray(firstMatrixRows, firstMatrixColumns);
Console.WriteLine($"Первая матрица:");
PrintArray(firstMatrix);

int[,] secondMatrix = GetArray(secondMatrixRows, secondMatrixColumns);
Console.WriteLine($"Вторая матрица:");
PrintArray(secondMatrix);

int[,] resultMatrix = new int[firstMatrixRows, secondMatrixColumns];
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < firstMatrix.GetLength(1); k++)
        {
            sum += firstMatrix[i, k] * secondMatrix[k, j];
        }
        resultMatrix[i, j] = sum;
    }
}
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);


Напишите программу, которая заполнит спирально массив 4 на 4.
*/
int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}



