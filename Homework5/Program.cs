// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int arrayLength = 6;
// int [] array = new int[arrayLength];
// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 1000);
//     System.Console.Write(array[i] + " ");
//     if (array[i] % 2 == 0)
//     {
//         count++;
//     }
// }
// System.Console.WriteLine();
// System.Console.WriteLine("Количество чётных чисел в массиве: " + count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int arrayLength = 6;
// int [] array = new int[arrayLength];
// int num = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(0, 10);
//     System.Console.Write(array[i] + " ");
//     if (i%2 > 0)
// {
//     num+= array[i];
// }
// }
// System.Console.WriteLine();
// System.Console.WriteLine("Сумма нечётных чисел в массиве: " + num);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int arrayLength = 6;
double [] array = new double[arrayLength];
double min = 100;
double max = 0;
double num = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().NextDouble()*100;
    array[i] = Math.Round(array[i], 2);
    System.Console.Write(array[i] + " ");
    if (min > array[i]) min = array [i];
    if (max < array[i]) max = array [i];
}
num = max - min;
System.Console.WriteLine();
System.Console.WriteLine($"{max} - {min} = {num}");