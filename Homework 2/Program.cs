//Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18


Console.WriteLine("Введите количество строк и столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int m = n;

Random rnd = new Random();

void CreateArray(int[,] array)
{
  for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < m; j++)
    {
      array[i, j] = new Random().Next(1, 10);
      Console.Write(array[i,j] + " ");
    }
  Console.WriteLine();
  }
}
Console.WriteLine("Созданы две матрицы:");
int[,] array1 = new int[m, n];
CreateArray(array1);

Console.WriteLine();

int[,] array2 = new int[m, n];
CreateArray(array2);

int[,] result = new int[m,n];

void MultyArray(int[,] array1, int[,] array2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < array1
    .GetLength(1); k++)
      {
        sum += array1
    [i,k] * array2[k,j];
      }
      result[i,j] = sum;
    }
  }
}


MultyArray(array1, array2, result);

Console.WriteLine("Произведение матриц:");
for (int i = 0; i < n; i++)
  {
    for (int j = 0; j < m; j++)
    {
      Console.Write(result[i,j] + " ");
    }
    Console.WriteLine();
  }
