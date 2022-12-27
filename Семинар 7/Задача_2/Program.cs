/* 
Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: 
Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
*/

Console.WriteLine("Введите кол-во строк m: ");
int m=Convert.ToInt32(Console.ReadLine()??"");
Console.WriteLine("Введите кол-во столбцов n: ");
int n=Convert.ToInt32(Console.ReadLine()??"");

void InitMatrix(int [,]array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {
            array[m,n]=m+n;
            Console.Write($"{array[m,n]} ");
        }
        Console.WriteLine();
    }
}

int [,] array=new int [m,n];
InitMatrix(array);
