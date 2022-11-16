// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введи число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumText = Convert.ToString(Number);
if (NumText.Length > 2)
{
  Console.WriteLine($"третья цифра ->  {NumText[2]}");
}
else 
{
  Console.WriteLine("-> третьей цифры нет");
}
