// Блок 1. Код для запуска в Visual Studio Code
List<int> ConvertStringToInt32List (string str)
{
    List<int> list = new();
    foreach (string s in str.Split(","))
    {
        list.Add(Convert.ToInt32(s));
    }
    return list;
}

Console.Clear();

try
{
    Console.Write("Введите количество кустов: ");
    int k = Convert.ToInt32(Console.ReadLine());

    while (k < 3 & k > 1000)
    {
        Console.Write("Вы ошиблись!\nВведите количество кустов: ");
        k = Convert.ToInt32(Console.ReadLine());
    }

    Console.Write("Введите через запятую количество ягод на каждом кусте: ");
    string y = Console.ReadLine()!;
    List<int> list_y = ConvertStringToInt32List(y);

    while (list_y.Count != k)
    {
        Console.Write("Вы ошиблись!\nВведите через запятую количество ягод на каждом кусте: ");
        y = Console.ReadLine()!;
        list_y = ConvertStringToInt32List(y);
    }

    int Sum = 0, SecondSum = 0;
    for (int i = 1; i < list_y.Count - 1; i++)
    {
        SecondSum = list_y[i] + list_y[i - 1] + list_y[i + 1];
        if (SecondSum > Sum)
            Sum = SecondSum;
    }

    if ((list_y[0] + list_y[^1] + list_y[^2]) > Sum)
        Sum = list_y[0] + list_y[^1] + list_y[^2];

    if ((list_y[0] + list_y[1] + list_y[^1]) > Sum)
        Sum = list_y[0] + list_y[1] + list_y[^1];

    Console.WriteLine($"Максимальное кол-во ягод, которое может быть собрано с трех соседних кустов: {Sum}");
}
catch (Exception e)
{
    Console.WriteLine($"Произошла ошибка при вводе числа. Подробнее: {e.Message}");
}

// Блок 2. Код для запуска на сайте https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=113&id_problem=695
// using System;
// using System.IO;

// internal class Program
// {
// 	private static void Main(string[] args) 
// 	{
// 		StreamReader sr = new StreamReader("input.txt");
//         StreamWriter sw = new StreamWriter("output.txt");
//         int k = Convert.ToInt32(sr.ReadLine());
//         string[] y = sr.ReadLine().Split();

//         int Sum = 0, SecondSum = 0;
//         for (int i = 1; i < y.Length - 1; i++)
//         {
//             SecondSum = Convert.ToInt32(y[i]) + Convert.ToInt32(y[i - 1]) + Convert.ToInt32(y[i + 1]);
//             if (SecondSum > Sum)
//                 Sum = SecondSum;
//         }

//         if ((Convert.ToInt32(y[0]) + Convert.ToInt32(y[y.Length-1]) + Convert.ToInt32(y[y.Length-2])) > Sum)
//             Sum = Convert.ToInt32(y[0]) + Convert.ToInt32(y[y.Length-1]) + Convert.ToInt32(y[y.Length-2]);

//         if ((Convert.ToInt32(y[0]) + Convert.ToInt32(y[1]) + Convert.ToInt32(y[y.Length-1])) > Sum)
//             Sum = Convert.ToInt32(y[0]) + Convert.ToInt32(y[1]) + Convert.ToInt32(y[y.Length-1]);

//         sw.WriteLine(Sum);
//         sr.Close();
//         sw.Close();
// 	}
// }