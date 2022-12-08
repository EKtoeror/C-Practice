//  Вывод случайного числа из отрезка [10,99]
// и показывает наибольшую цифру этого числа

int GetRandomNumber(int left, int right)/*функция возвращающая число 
из данного отрезка*/
{
    Random rnd = new Random();//класс рандом
    int number = rnd.Next(left, right + 1);
    return number;
}
int GetMaxDigitOfNumber(int number)//функция возвращающая максимальную цыфру числа
{
    int firstDigit = number / 10; //определение десятков
    int secondDigit = number % 10; //определение едениц

    if (firstDigit > secondDigit)
        return firstDigit;
    else
        return secondDigit;
}

int number = GetRandomNumber(10, 99);
Console.WriteLine($"Число {number}");

int maxDigit = GetMaxDigitOfNumber(number);
Console.WriteLine(maxDigit);