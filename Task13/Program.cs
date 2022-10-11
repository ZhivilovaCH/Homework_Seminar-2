//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число:");
int num = int.Parse(Console.ReadLine()!);
int x1 = num/10;

if (x1>10 && x1<100)
{
    x2 = x1%10
    Console.WriteLine($"Третья цифра указанного числа" {x2}");
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}