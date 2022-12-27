/* 
Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.WriteLine("Введите кол-во строк m: ");
int m = Convert.ToInt32(Console.ReadLine() ?? "");
Console.WriteLine("Введите кол-во столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine() ?? "");

void MakeMatrix(int[,] array)
{
    int sum=0;
    for (int m = 0; m < array.GetLength(0); m++)
    {
        for (int n = 0; n < array.GetLength(1); n++)
        {

            array[m, n] = new Random().Next(1, 10);
            Console.Write($"{array[m, n]} ");

            if (m==n)
            {
                sum=sum+array[m,n];
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма элементов главной диагонали массива = {sum}");
}
int[,] array = new int[m, n];
MakeMatrix(array);

