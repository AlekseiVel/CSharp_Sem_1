// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

int max = 0;
int numberA = 0;
int numberB = 0;

Console.Write("Введите первое число: ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
numberA = int.Parse(Console.ReadLine()!);

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;

Console.WriteLine($"Большее число - {max}");