// напишите программу, которая на вход принимает два числа
// и проверяет, является ли второе число квадратом первого

Console.WriteLine("Введите первое число");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");
int numberB = int.Parse(Console.ReadLine());

if(numberB == numberA * numberA)
{
    Console.WriteLine("Да!");
}
else
{
Console.WriteLine("Нет!");
}