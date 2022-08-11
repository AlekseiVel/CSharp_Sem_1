// напишите программу, которая на вход принимает число
// и выдает его квадрат

Console.WriteLine("Введите число квадрат которого надо найти");
int number = int.Parse(Console.ReadLine());

// int sqr = number*number;
double sqr = Math.Pow(number, 2);

Console.WriteLine($"Квадрат числа {number} равен:  {sqr}");
