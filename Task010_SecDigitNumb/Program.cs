// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int num = new Random().Next(0, 1000);
Console.Write("Исходное число: ");
Console.WriteLine(num);

if((num / 100 > 0) && (num / 100 < 10))
{
    int SecondDigit = num % 100;
    SecondDigit = SecondDigit / 10;
    Console.Write("Вторая цифра этого числа: ");
    Console.WriteLine(SecondDigit);
}
else
{
    Console.WriteLine("Число не трехзначное!");
}