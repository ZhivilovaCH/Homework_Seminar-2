//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число:");
int num = int.Parse(Console.ReadLine()!);
int x1 = num/10;
int x2 = x1%10;
Console.WriteLine($"Вторая цифра числа {x2}");


