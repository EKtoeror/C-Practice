/*  Задайте массив из 12 элементов из случайных чисел промежутка [-9,9] 
и найдите сумммы: положительных и отрицательных*/

/*
1. получить размерность с конца
2. получить заполненный массив рандомными числами
3. распечатать массив на консоль
4. найти сумму уположительных элементов
5. найти сумму отрицательных элементов
6*. попробовать сделать  это в одном методе
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
    int[] array = new int[dimension];
    Random rnd = new Random();

    for (int i = 0; i < dimension; i++)
    {
        array[i] = rnd.Next(-20, 20);
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

int GetPosSum(int[] array) // 4.
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int GetNegSum(int[] array) // 5.
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

(int,int) GetSums(int []array)//картеж 4+5
{
    int positiveSum=0;
    int negativeSum=0;
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i]>0)
            
                positiveSum+=array[i];
            else 
            
                negativeSum+=array[i];
            
        }
        return (positiveSum,negativeSum);
    }
}

int dimension = GetNumber("Введите размерность массива");
int[] array = IntArray(dimension);

PrintArray(array);
int positive=GetPosSum(array);
int negative=GetNegSum(array);

(int positiveSum,int negativeSum)=GetSums(array);

Console.WriteLine($"Сумма положительных: {positiveSum}");
Console.WriteLine($"Сумма отрицательных: {negativeSum}");

Console.WriteLine($"Сумма положительных: {positive}");
Console.WriteLine($"Сумма отрицательных: {negative}");