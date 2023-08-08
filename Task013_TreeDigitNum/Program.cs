// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int num = new Random().Next(0, 10000);
Console.Write("Заданное число: ");
Console.WriteLine(num);

if(num > 99)
{
    while(num > 1000)
    {
        num = num / 10;
    }
    num = num % 10;
    Console.Write("Третья цифра заданного числа: ");
    Console.WriteLine(num);
}
else
{
    Console.Write("Третьей цифры нет.");
}