//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число от 0 до 100 000:");
int num = int.Parse(Console.ReadLine()!);
int x1 = 0;
int x2 = 0;

if (num>100 && num<100000)
{
    x1 = num/10;
    x2 = x1%10;
    Console.WriteLine($"Третья цифра указанного числа{num}->{x2} ");
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}