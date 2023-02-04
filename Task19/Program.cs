// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Решение сведено к универсальному: программа принимает число в диапазоне от Int32.MinValue до Int32.MaxValue, которое является двузначным и более
string ReverseString(string Str)
{
    string ReverseStr = string.Empty;
    for (int Index = Str.Length - 1; Index >= 0; Index--)
    {
        if (Str[Index] != '-')
            ReverseStr = ReverseStr + Str[Index].ToString();
    }
    return ReverseStr;
}

Console.Clear();
Console.Write("Введите число (от двухзначного и выше): ");
try
{
    int n = Convert.ToInt32(Console.ReadLine());

    while (n / 10 == 0)
    {
        Console.Write("Вы ошиблись!\nВведите число (от двухзначного и выше): ");
        n = Convert.ToInt32(Console.ReadLine());
    }

    string Absolute = string.Empty;
    if (n < 0)
        Absolute = " по модулю";

    if (Math.Abs(n).ToString() == ReverseString(n.ToString()))
        Console.WriteLine($"Число {n}{Absolute} является палиндромом");
    else
        Console.WriteLine($"Число {n}{Absolute} не является палиндромом");
}
catch(Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}
