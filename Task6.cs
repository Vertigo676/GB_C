// Напишите программу, которая принимает на вход число и определяет, является ли оно чётным (делится на 2 без остатка).

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number%2 == 0)
{
    Console.WriteLine($"Да, число {number} четное");
}
if(number%2 == 1)
{
    Console.WriteLine($"Нет, число {number} нечетное");
}