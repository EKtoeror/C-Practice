// На входе 2 числа: является ли одно квадратом второго 

Console.WriteLine("Введите 2 числа: ");
string n1 = Console.ReadLine() ?? "";
string n2 = Console.ReadLine() ?? "";

int number1 = Convert.ToInt32(n1);
int number2 = Convert.ToInt32(n2);

number1 = Math.Abs(number1);
number2 = Math.Abs(number2);

void ShowResult(int number1, int number2)
{
    int a = number1 * number1;
    int b = number2 * number2;
    if (number2 == a)
        Console.WriteLine($"Число {number2} является квадратом числа {number1}");
    else if (number1 == b)
        Console.WriteLine($"Число {number1} является квадратом числа {number2}");
    else
        Console.WriteLine($"Ни число {number1} ни число {number2} не являются квадратами друг друга");
}

ShowResult(number1, number2);

/* 
if (number2 == a) || (number1 == b)
    Console.WriteLine("Одно число является квадратом второго");
else
    Console.WriteLine($"Ни число {number1} ни число {number2} не являются квадратами друг друга");
*/    