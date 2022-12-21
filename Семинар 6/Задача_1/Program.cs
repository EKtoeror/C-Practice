/* Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

/*
1.Получение числа (размерность массива)
2.Инициализация массива
3.Печать массива
4.Перевернуть массив
*/

int GetNumber(string message) //1.
{
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Введите корректное число");
        }
    }
    return result;
}

int[] IntArray(int dimension) //2.
{
    Random rnd = new Random();
    int[] array = new int[dimension];

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

void PrintArray(int[] array) //3.
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)//4. Array.Reverse(result)
{
    int [] result=new int[array.Length];
    int count=0;

    for (int i = array.Length; i >=0; i--)
    {
        result[count]=array[i];
    }
    return result;
}

int dimension = GetNumber("Введите размерность массива");
int [] array=IntArray(dimension);
PrintArray(array);

int []result=ReverseArray(array);
PrintArray(result);