// на входе число Н выдает таблицу квадратов числе от 1 до Н
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

for (int i =1 ; i<= number ; i++)
{
    int result = i*i;
    Console.WriteLine($" {i}^2 = {result}");
}
