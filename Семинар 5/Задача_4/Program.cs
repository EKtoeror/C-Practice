/* Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

void MakeArray(int[] array)
{
    Console.Write("[");
    int quantity=0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
        if (array[i] >= 10 && array[i] <= 99)
        {
            quantity++;
        }
    }

    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine(quantity);
}
int[] array = new int[23];
MakeArray(array);