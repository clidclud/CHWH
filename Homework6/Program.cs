// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// int length = 6;
// int [] array = new int [length];
// int j = 0;

// System.Console.WriteLine("Введите число");

// for (int i = 0; i < length; i++)
// {
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     if (array [i] > 0)
//     j += 1;
// }

// Console.WriteLine($"Чисел больше нуля: {j}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToDouble(Console.ReadLine());

if(k1==k2 && b1==b2)
{
    System.Console.WriteLine("Прямые совпадают");
}
else if(k1==k2)
{
    System.Console.WriteLine("Параллельны");
}
else
{
double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;
Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {x}, Y: {y}");
}