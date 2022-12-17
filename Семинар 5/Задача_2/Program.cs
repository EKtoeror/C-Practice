// Напишите программу замены положительных элементов массива на отрицательыне

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
}


void Replace(int []array)
{
    Console.WriteLine();
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i]=array[i]*(-1);
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }

    Console.Write("]");
}

int[] array = new int[8];
MakeArray(array);
Replace(array);

