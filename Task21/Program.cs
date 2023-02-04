// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
Console.Clear();
try
{
    Console.Write("Введите координтату X1: ");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координтату Y1: ");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координтату Z1: ");
    double z1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координтату X2: ");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координтату Y2: ");
    double y2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите координтату Z2: ");
    double z2 = Convert.ToDouble(Console.ReadLine());

    double S = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine($"Расстояние между двумя точками в пространстве равно {Math.Round(S, 2)}");
}
catch (Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}