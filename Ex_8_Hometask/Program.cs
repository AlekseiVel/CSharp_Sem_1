//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int i = 2;
int number = 0;

Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine()!);

while (i <= number)
{
        Console.Write($"{i} ");
        i += 2;
}