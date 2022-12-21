/* Не используя рекурсию, 
выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.*/

Console.WriteLine("Введите число: ");

int number =Convert.ToInt32(Console.ReadLine()??"");
/*
int result=0;
for (int i = 0; i < number-1; i++)
{
    for (int j =0; number-2> j; j--)
    {
        result=j+i;
        Console.WriteLine(result);
    }

}


5
0
1
1+0=1
    1+1=2
        2+1=3
        */


/*int num1=0;
int num2=1;
for (int i = 0; i < number; i++)
{
    int fresult = i;
    Console.Write($"{fresult} ");
    /*for (int j = 1; j < number; j++)
    {
        int sresult = j;
        Console.Write($" {sresult} ");
    }
}
num1+num2=num3
     num2+num3=num4
          num3+num4=num5*/

for (int i = 0; i <number; i++)
{
    int result = i-1;
    Console.Write($" {result} ");
}
