// Задача 4: Напишите программу, которая принимает на вход три 
// числа и выдаёт максимальное из этих чисел.

int max = 0, numberA = 0, numberB = 0, numberC = 0;

Console.Write("Введите первое число: ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
numberB = int.Parse(Console.ReadLine()!);

Console.Write("Введите третье число: ");
numberC = int.Parse(Console.ReadLine()!);

if(numberA > max) max = numberA;
if(numberB > max) max = numberB;
if(numberC > max) max = numberC;

Console.WriteLine($"Максимальное число из трех: {max}");