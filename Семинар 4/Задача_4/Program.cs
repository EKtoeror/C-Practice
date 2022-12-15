// выводит массив из 8ми элементов заполненый 0 и 1 в случайном порядке
void FillArray(int[] collection)
{
    int length = 8;//collection.Length;

    Console.Write("[");

    for (int i=0;i < length; i++)
    {
        collection[i] = new Random().Next(0, 2);
        Console.Write(collection[i]);
        if (i < length - 1) 
            {
                Console.Write(",");
            }
    }
    Console.Write("]");
}

int[] array = new int[8]; 
FillArray(array);
