// Напиишите программу,которая определит присутствует ли данное число в массиве
void MakeArray(int[] array,int find)
{
        Console.Write("[");
    int position=-1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 20);
        Console.Write(array[i]);
        
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
        if(array[i]==find)
        {
            find=i;
            break;
        }
    }

    Console.Write("]");
    Console.WriteLine();

    if (position==-1)
    {
        Console.WriteLine("Элемента нет в массиве");
    }
    else
    {
        Console.WriteLine($"Элемент присутсвует в массиве");
    }
}

int []array=new int[10];
MakeArray(array,3);



