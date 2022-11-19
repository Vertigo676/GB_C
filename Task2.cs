// Напишите программу, которая принимает на вход 2 числа и выдаёт максимальное и минимальное из них.

Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA > numberB)
{
    Console.WriteLine($"{numberA} это максимальное число");
    Console.WriteLine($"{numberB} это минимальное число");
}
else
{
     Console.WriteLine($"{numberA} это минимальное число");
     Console.WriteLine($"{numberB} это максимальное число");
}

