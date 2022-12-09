/* На входе 2 числа и вывод является ли 2ое кратно 1му,
если нет выводит остаток от деления */

Console.WriteLine("Введите 2 числа: ");
string n1 = Console.ReadLine() ?? "";
string n2 = Console.ReadLine() ?? "";

int number1 = Convert.ToInt32(n1);
int number2 = Convert.ToInt32(n2);

number1 = Math.Abs(number1);
number2 = Math.Abs(number2);

if (number2 % number1 == 0)
{
    Console.WriteLine($"Число {number2} кратно {number1}");
}
else
{
    int result = number2 % number1;
    Console.WriteLine($"Число {number2} не кратно {number1}, остаток {result}");
}


/*
void ShowResult (int number1, int number2)
{
    int result = number1%number2;
    if (result ==0) Console.WriteLine($"Число {number2} кратно {number1}");
    else Console.WriteLine($"Число {number2} не кратно {number1}, остаток {result}");
} 
ShowResult(number1 ,number2);
*/