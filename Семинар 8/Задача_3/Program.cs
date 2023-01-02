/* 
Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, сколько раз 
встречается элемент входных данных.
1, 2, 3
4, 6, 1
2, 1, 6

1 встречается 3 раза
2 встречается 2 раз
3 встречается 1 раз
4 встречается 1 раз
6 встречается 2 раза
*/
void InitMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 99);
        }
    }
}
void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Dictionary(int[,] array)
{
    int dig = 1;
    int maxDig = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > maxDig)
            {
                maxDig = array[i, j];
            }
        }
    }
    while (dig<=maxDig)
    {
        int count=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (dig==array[i, j])
                    {
                        count++;
                    }
            }
        }
        if (count!=0)
        {
            if (count==1)
            Console.WriteLine($"Число {dig} содержиться {count} раз");
            if (count!=1)
            Console.WriteLine($"Число {dig} содержиться {count} раза");
        }
        dig++;   
    }
}

int[,] array = new int[4, 4];
InitMatrix(array);
PrintMatrix(array);
Console.WriteLine();
Dictionary(array);

/*
void CalculateNumbers (int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    int numberOfElements = m * n;
    int number = 0;
    int count = 0;
    int total = 0;

    while (total != numberOfElements)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if(matrix[i, j] == number)
                {
                    count++;
                }
            }
        }
System.Console.WriteLine($"Число {number} встречается {count} раз;");
total+= count;
count = 0;
number++;
    }
}
*/
