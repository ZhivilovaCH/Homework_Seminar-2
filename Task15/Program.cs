//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();
Console.WriteLine("Введите число от 1 до 7:");
int x = int.Parse(Console.ReadLine()!);

if (x>=1 && x<6)
{
    Console.WriteLine("Будний день");
}
else if (x==6) 
{
    Console.WriteLine("Выходной");
}
else if (x==7) 
{
    Console.WriteLine("Выходной");
}
