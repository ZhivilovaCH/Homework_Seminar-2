//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите число от 0 до 100 000:");
int num = int.Parse(Console.ReadLine()!);

if(num>=100)
{
while(num >=1000)
{
   num= num/10;
}
int x1 = num%10;
Console.WriteLine($"Третья цифра числа {x1}");
}

if(num<100)
{
    Console.WriteLine($"Третья цифра не существует");
}