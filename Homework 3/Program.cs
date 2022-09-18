Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

if ((n*m) > 50) Console.WriteLine("Введите другие числа");


Random rnd = new Random();

void CreateArray(int[,] array)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            
            array[i, j] = new Random().Next(10, 100);
            Console.Write(array[i,j] + " ");
            
        }
    Console.WriteLine();
    }
}

int[,] array1 = new int[n, m];
CreateArray(array1);

int[] uniqueArray = new int[countUnique];

int k = 0;

for (int i = 0; i < uniqueArray.Length; i++)
{
    for ( ; k < array.Length; k++)
    {
        counter = 0;
        
        for (int j = 0; j < array.Length; j++)
        {
            if (array[k] == array[j])                    
                counter++;                     
        }
        if (counter == 1)
        {
            uniqueArray[i] = array[k];
            k++;
            break;
        }                    
    }
}