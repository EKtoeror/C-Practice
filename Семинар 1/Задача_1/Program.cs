// Квадрат числа на вводе


Console.WriteLine("Введите число");
string numberStr = Console.ReadLine() ?? ""; ///с консоли всегда Str
int number = Convert.ToInt32(numberStr);// конвертация в переменной в int 

int result = number * number;

Console.WriteLine($"Квадрат числа {number} = {result}");/* $ - оператор для внедрения 
переменных в строку*/

