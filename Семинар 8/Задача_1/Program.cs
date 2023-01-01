/*
 Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива.
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
    
    int []first=new int [array.GetLength(1)];
    int []last= new int [array.GetLength(1)];
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            first[j]=array[0,j];
            last[j]=array[array.GetLength(0)-1,j];
            
            if (i==0)
            {
                array[i,j]=last[j];
                array[array.GetLength(0)-1,j]=first[j];
            } 
        }
        
    }
    

}
int [,]array=new int[4,4];
InitMatrix(array);
PrintMatrix(array);
Console.WriteLine();
Replace(array);
PrintMatrix(array);


