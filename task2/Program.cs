//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = 0;

while (a > 0)
{
    result = result + a % 10;
    a = a / 10;
}
Console.WriteLine();
Console.WriteLine("Сумма цифр в числе = " + result);

