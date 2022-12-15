// на вход число на выходе кол-во цыфр в этом числе

Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine() ?? "");
int number2 = number;

void DigitQuantity(int number)
{
    int quantity = 0;
    while (number != 0)
    {
        quantity = quantity + 1;
        number = number / 10;
    }
    Console.WriteLine($"Кол-во цыфр в числе {number2} = {quantity}");

    /*string n = Convert.ToString(number);
    int size =n.Length;
    Console.WriteLine($"Кол-во цыфр в числе {number} = {size}");*/
}
DigitQuantity(number);

