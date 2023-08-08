// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int dayNum = new Random().Next(1, 15);
Console.Write("День недели номер: ");
Console.WriteLine(dayNum);

if(dayNum > 0 && dayNum <= 7)
{
    if(dayNum > 5 && dayNum <= 7)
    {
        Console.WriteLine("Выходной.");
    }
    else
    {
        Console.WriteLine("Рабочий.");
    }
}
else
{
    Console.WriteLine("Это не день недели.");
}

