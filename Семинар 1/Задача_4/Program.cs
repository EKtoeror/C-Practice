// На ввод Число N а на выходе все целые числа от -N до N

Console.WriteLine("Введите число");
string number = Console.ReadLine() ?? "";

int n = Convert.ToInt32(number);

n = Math.Abs(n);// по модулю

for (int i = (-n); i <= n; i++)//цикл
{
    Console.Write(i+" ");
}