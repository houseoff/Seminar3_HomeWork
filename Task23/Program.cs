// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.Clear();
try
{
    Console.Write("Введите число: ");
    uint n = Convert.ToUInt32(Console.ReadLine());

    Console.Write($"Кубы чисел от 1 до {n} включительно: "); 
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{i * i * i} ");
    }
}
catch (Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}
