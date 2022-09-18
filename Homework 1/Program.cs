//Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Номер строки с наименьшей суммой элементов: 1 строка
//(допускается указывать индекс строки в массиве, в данном примере - 0)

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

int value = 0;
int min = int.MaxValue;
int index = 0;
int Sum = 0;

Random rnd = new Random();

int[,] array = new int [m, n];

for (int i = 0; i < m; i++)
{
    for (int y = 0; y < n; y++)
    {
        array[i,y] = rnd.Next(1, 10);
        Console.Write(array[i,y] + " ");

    }
    Console.WriteLine();
}

for(int i = 0; i < m; i++)
{
    value = 0;
    for(int j = 0; j < n; j++)
    {   
        value += array[i, j];  
    }
    if(value < min)
    {
        Sum = value; 
        index = i;
    } 
    min = value;
}
Console.WriteLine("Наименьшаяя сумма = {0}", Sum);
Console.WriteLine("Номер строки с наименьшей суммой элементов: {0} строка ", index+1);