// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 < 1000 & num1 > 99)
{
    int num2 = num1 / 10;
    int num3 = num2 % 10;
    Console.WriteLine($"Второе число {num3}");
}
else
{
    Console.WriteLine("Вы ввели неверное число");
}