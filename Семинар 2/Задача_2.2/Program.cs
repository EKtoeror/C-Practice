// Выводит 3ех значное число и удаляет вторую цыфру

int GetRandomNumber(int left, int right)    /*функция возвращающая число 
из данного отрезка*/
{
    Random rnd = new Random();//класс рандом
    int number = rnd.Next(left, right + 1);
    return number;

}

string /*int*/ DeleteSecontDigit(int number)
{
    int firstDigit = number / 100;//определяю первую и вторую цыфру
    int thirdDigit = number % 10;
    string number01 = ($"{firstDigit}{thirdDigit}");//завожу их в переменную (строка)
    // int number01 = ((number/100)*10+(number%10));
    return number01;
}

int number = GetRandomNumber(100, 999);
Console.WriteLine($"Число {number}");

string /*int*/ result = DeleteSecontDigit(number);
Console.WriteLine(result);

//В1
/* int GetRandomNumber();
return new Random().Next(100,1000);

void ShowRandomNumber(int number)
{
    Console.WriteLine($"...{number}");
    string str = number.ToString(); - конвертация {number} в строку {str}
    Console.WriteLine($>"{str[0]str[2]"}); - вывод по индексам
}

ShowRandomNumber(GetRandomNumber());
*/

//В2
/* int GetRandomNumber();
return new Random().Next(100,1000);

void ShowRandomNumber(int number)
{
    Console.WriteLine($"...{number}");
    int result = ((number/100)*10+(number%10))
    Console.WriteLine(result);
}

ShowRandomNumber(GetRandomNumber());
*/