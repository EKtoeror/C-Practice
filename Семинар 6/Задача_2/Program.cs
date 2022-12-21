/* Напишите программу, которая принимает на вход три числа и проверяет,
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше 
суммы двух других сторон.*/


Console.WriteLine("Введите 1ое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2ое число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число");
int num3 = Convert.ToInt32(Console.ReadLine());

if (num1 < (num1 + num2) && num2 < (num1 + num3) && num3 < (num1 + num2))
{
    Console.WriteLine("Существует");
}
else
{
    Console.WriteLine("Не существует");
}

/*
bool Ass(int num1,int num2,int num3)
{
    return num1<num2+num3&&num2<num1+num3&&num3<num1+num2;
}
int num1
int num2
int num3

Console.WriteLine($"...." +(Ass) ? "" : "false"+ "....");
*/