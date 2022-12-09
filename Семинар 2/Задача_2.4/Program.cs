// На входе число и проверяет кратно ли 7 и 23 одновременно
Console.WriteLine("Введите число: ");
string n = Console.ReadLine() ?? "";

int number = Convert.ToInt32(n);

number = Math.Abs(number);

void ShowResult(int number)
{
    int a7 = number % 7;
    int a23 = number % 23;
    if (a7 == 0 && a23 == 0) Console.WriteLine($"Число {number} кратно 7 и 23");
    else Console.WriteLine($"Число {number} не кратно 7 и 23");
}

ShowResult(number);

