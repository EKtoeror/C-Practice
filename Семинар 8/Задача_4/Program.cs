/*
Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец,
на пересечении которых расположен наименьший элемент массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим
следующий массив:
9 4 2    9 2 3
2 2 6    4 2 4
3 4 7    2 6 7   
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
int[,] DeleteRowColumns(int[,] array)//если функция на выходе возвращет новый массив
{
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int minDig = int.MaxValue;//array[0,0]
    int minRow = 0;
    int minCol = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < minDig)
            {
                minDig = array[i, j];
                minRow = i;
                minCol = j;
            }
        }
    }
    
    int m=0;//задаем счетчики для новой матрицы
    int n=0;

    for (int i = 0; i < array.GetLength(0); i++)//пробег по всем значениям старого массива
    {
       if (i==minRow)
       {
        continue;//пропуск строки с наименьшим значением
       }
       for (int j = 0; j < array.GetLength(1); j++)
       {
            if (j==minCol)
            {
                continue;//пропуск столбца с наименьшим значением  
            }
            newArray[m,n]=array[i,j];
            n++;
       }
       n=0;
       m++;

    }
    return newArray;
    
    //Console.WriteLine($"{minDig} ({minRow},{minCol})");
    //Console.WriteLine();
}

int[,] array = new int[4, 4];
InitMatrix(array);
PrintMatrix(array);
Console.WriteLine();
//DeleteRowColumns(array);
PrintMatrix(DeleteRowColumns(array));

