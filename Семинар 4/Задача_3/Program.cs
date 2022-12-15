// на входе N и выдает !
Console.Write("Введите число : ");

int number=Convert.ToInt32(Console.ReadLine()??"");

void Factorial(int number)
{
    int result =1;
    for (int i = 1; i <= number; i++)
    {
        result = result * i;
    }
    Console.WriteLine($"{number}! = {result}");
}
Factorial(number);