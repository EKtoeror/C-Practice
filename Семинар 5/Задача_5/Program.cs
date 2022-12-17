/* Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
void MakeArray(int[] array)
{
    Console.Write("[");
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
        
    }

    Console.Write("]");
    Console.WriteLine();
}
void ProductOfPairs(int []array)
{
    Console.Write("[");
    int [] result;
    for (int i = 0; i < array.Length/2; i++)
    {
        result = new int [array.Length/2];

        int num1=array[i];
        int num2=array[array.Length-1-i];

        result[i] = num1*num2;
        Console.Write($"{result[i]}");
        
        if (i<result.Length-1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}


int[] array = new int[11];
MakeArray(array);
ProductOfPairs(array);