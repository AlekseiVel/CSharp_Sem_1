//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

int number = 0;

Console.Write("Введите число для проверки: ");
number = int.Parse(Console.ReadLine()!);

if(number % 2 == 0)
{
    Console.WriteLine($"Число {number} - четное.");
}
else
{
    Console.WriteLine($"Число {number} - нечетное.");
}