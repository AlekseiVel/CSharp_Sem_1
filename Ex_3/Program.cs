// Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.

//Понедельник = 1;
//Вторник = 2;
//Среда = 3;
//Четверг = 4;
//Пятница = 5;
//Суббота = 6;
//Воскресенье = 7;

Console.WriteLine("ведите номер дня недели? (1-7)");
int number = int.Parse(Console.ReadLine()!);

switch (number)
{
    case 1:
    {
        Console.WriteLine("Понедельник");
        break;
    }
    case 2:
    {
        Console.WriteLine("Вторник");
        break;
    }
    case 3:
    {
        Console.WriteLine("Среда");
        break;
    }    
    case 4:
    {
        Console.WriteLine("Четверг");
        break;
    }
    case 5:
    {
        Console.WriteLine("Пятница");
        break;
    }
    case 6:
    {
        Console.WriteLine("Суббота");
        break;
    }
    case 7:
    {
        Console.WriteLine("Воскресенье");
        break;
    }
}