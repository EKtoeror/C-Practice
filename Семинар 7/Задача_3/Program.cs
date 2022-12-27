/* 
Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

Console.WriteLine("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine() ?? "");

void MakeMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {

            array[m,n]=new Random().Next(1,10);
            Console.Write($"{array[m, n]} ");    
        }
        Console.WriteLine();
    }
}

void RedactMatrix(int[,] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            if (m % 2 == 1 && n % 2 == 1)
            {
                array[m,n]=array[m,n]*array[m,n];
            }
            Console.Write($"{array[m, n]} ");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[m, n];
MakeMatrix(array);
Console.WriteLine();
RedactMatrix(array);

