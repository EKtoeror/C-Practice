/* Принимает на вход 3ех значное число и на выходе показывает последнюю цыфру этого 
числа*/

Console.WriteLine("Введите число");
string number = Console.ReadLine() ?? "";

int n = Convert.ToInt32(number);

n = Math.Abs(n);// для ввода отрицательных чисел

if ((n>=100) && (n<=999))//для проверки 3ех значности чисел
    Console.WriteLine(n % 10);// остаток от деления на 10
else 
    Console.WriteLine("Введено неверное число");

// так делать нельзя 
/*
string number = Console.ReadLine() ?? "";
Console.WriteLine(number[2]);
*/