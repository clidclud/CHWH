// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.WriteLine("Для сравнения двух целых чисел, введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 < num2)
// {
// Console.Write("Число ");
// Console.Write(num1);
// Console.Write(" меньше числа ");
// Console.Write(num2);
// }
// else if (num1 == num2)
// {
// Console.Write("Число ");
// Console.Write(num1);
// Console.Write(" равно числу ");
// Console.Write(num2);
// }
// else
// {
// Console.Write("Число ");
// Console.Write(num1);
// Console.Write(" больше числа ");
// Console.Write(num2);
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.WriteLine("Для сравнения трех целых чисел, введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;
// if (num2 > max) max = num2;
// if (num3 > max) max = num3;
// Console.Write("Самое большое число ");
// Console.Write(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Console.WriteLine("Для определения четности числа, введите число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num%2 == 0)
// Console.Write("Число четное");
// else
// Console.Write("Число не четное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("Для вывода всех четных чисел в порядке возрастания, введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(1);
// while (N < 0)
// {
// Console.WriteLine("Число отрицательное, введите положительное число");
// N = 0;
// N = Convert.ToInt32(Console.ReadLine());
// }
// while (N >= n)
// {
// if (n%2 == 0)
// {
// Console.Write(n);
// Console.Write(" ");
// }
// n = n + 1;
// }