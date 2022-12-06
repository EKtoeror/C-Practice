// На входе 2 числа и проверяет 1ое число квадрат ли второго

Console.WriteLine("Введите числа");
string number1 = Console.ReadLine() ?? "";
string number2 = Console.ReadLine() ?? "";

int number01 = Convert.ToInt32(number1);
int number02 = Convert.ToInt32(number2);

if (number02 * number02 == number01)
{
    Console.WriteLine($"{number01} является квадратом {number02}");
}
else
{
    Console.WriteLine($"{number01} не является квадратом {number02}");
}