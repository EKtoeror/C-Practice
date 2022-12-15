// вход число А выдает сумму чисел от 1 до А

/*
    1. метод который читает число с консоли
    2. метод который считает сумму от 1 до N
*/

int GetNumber(string message) //1.
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        if (int.TryParse(Console.ReadLine(), out result)&& result >0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Некорректный ввод.Введите число больше 0.");
        }
    }
    return result;
}

int GetSum(int number) //2.
{
    int sum =0;
    for (int i = 0; i <=number; i++)
    {
        sum+=i;//sum=sum+i
    }
    return sum;
}
int number = GetNumber("Введите число больше 0");
int sum=GetSum(number);

Console.WriteLine($"Сумма чисел от 1 до {number} = {sum}");