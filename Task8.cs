// Напишите программу, которая на вход принимает число и выдает все четные числа до него от 1.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 1;
while(count <= number)
 {
     if(count%2 == 0)
     Console.WriteLine(count);
     count++;
 }
