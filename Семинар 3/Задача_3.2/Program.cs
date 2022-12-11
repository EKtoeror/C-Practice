// по номеру четверти покажет диапозон координат точек в этой четверти

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0 && result <= 4)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Ввели некорректное число");
        }
    }
    return result;
}


void GetCoordinates(int quarter)
{
    if (quarter == 1) 
    {
        Console.WriteLine($"В {quarter} четверти диапозон коодинат (-infinity;+infinity)");
    }
    if (quarter == 2)
    {
       Console.WriteLine($"В {quarter} четверти диапозон коодинат (+infinity;+infinity)"); 
    }
    if (quarter == 3)
    {
        Console.WriteLine($"В {quarter} четверти диапозон коодинат (-infinity;-infinity)"); 
    }
    if (quarter == 4)
    {
        Console.WriteLine($"В {quarter} четверти диапозон коодинат (+infinity;-infinity)"); 
    }
}
int quarter = GetNumber("Введите ночер четверти: ");
GetCoordinates(quarter);

