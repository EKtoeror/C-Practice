/* Напишите программу которая принимает координаты точки (x и y)
причем они не равны 0 и выдает номер четверти плоскости у которой она находится*/

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result != 0)
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

int GetQuarter(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x > 0 && y < 0)
        return 4;
    if (x < 0 && y < 0)
        return 3;
    return 2;
}

int x = GetNumber("Введите координату x: ");
int y = GetNumber("Введите координату y: ");
int quarter = GetQuarter(x, y);

Console.WriteLine($"Точка с координатами {x}, {y} лежит в {quarter} четверти");
