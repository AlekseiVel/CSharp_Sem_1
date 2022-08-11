// Задача 2: Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

int numberA = 0;
int numberB = 0;

Console.Write("Введите первое число: ");
numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число: ");
numberB = int.Parse(Console.ReadLine()!);

if(numberA > numberB)
{
    Console.WriteLine($"Число {numberA} - большее, число {numberB} - меньшее.");
}
else
{
    Console.WriteLine($"Число {numberB} - большее, число {numberA} - меньшее.");
}