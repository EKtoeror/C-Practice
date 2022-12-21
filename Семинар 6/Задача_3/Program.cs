// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Введите число: ");
string number = Console.ReadLine()??"";
int fromBase = 10; //из какого разряда
int toBase = 2; // в какой разряд

string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
//первый аргумент должен быть строкой

Console.WriteLine($"Число {number} в {toBase}ой системе {result}");
