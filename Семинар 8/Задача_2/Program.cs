/* 
Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, 
если это невозможно, программа должна вывести сообщение для пользователя.
*/
void InitMatrix(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j]=new Random().Next(1,10);
        }
    }
}
void PrintMatrix(int [,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
void Replace(int [,]array)
{
    int [,]result=new int[array.GetLength(1),array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j <array.GetLength(0) ; j++)
        {
            result[i,j]=array[j,i];
            Console.Write($"{result[i,j]} ");
        }
        Console.WriteLine();
    }
}

int [,]array=new int[3,5];
InitMatrix(array);
PrintMatrix(array);
Console.WriteLine();
Replace(array);


