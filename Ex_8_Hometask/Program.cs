//Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

int i = 0;
int number = 0;

Console.Write("Введите число: ");
number = int.Parse(Console.ReadLine()!);

while (i <= number - 3)
{
    i += 2;
    Console.Write($"{i} ");
}