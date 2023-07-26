// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// System.Console.WriteLine("Введите число строк");
// int rows = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine("Введите число столбцов");
// int colums = Convert.ToInt32(Console.ReadLine());

// double [,] matrix = new double [rows,colums];

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         matrix [i,j] = new Random().NextDouble()*10;
//         matrix [i,j] = Math.Round(matrix[i,j], 2);
//         System.Console.Write(matrix[i,j]+" ");
//    }
//    System.Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Решение 2ух задач в одной программе

WorkingWithTwoDimensionalArrays();
void WorkingWithTwoDimensionalArrays()                                   // Генерация массива
{
System.Console.WriteLine("Введите число строк");    
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите число столбцов");
int colums = Convert.ToInt32(Console.ReadLine());

int [,] matrix = new int [rows,colums];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix [i,j] = new Random().Next(0,10);
        System.Console.Write(matrix[i,j] + " ");
    }
   System.Console.WriteLine();
}                                                                   // Генерация массива

System.Console.WriteLine("Выбирите задачу на проверку: 1 или 2");   // Выбор проверки задания
int task = Convert.ToInt32(System.Console.ReadLine());
while (task > 2 || task <= 0)
{
    System.Console.WriteLine("Такой задачи нет, введите номер задачи 1 или 2");
    task = Convert.ToInt32(System.Console.ReadLine());
}
if (task == 1) ReturnElement(matrix);
if (task == 2) ArithmeticMeanOfTheElementsInEachColumnfor(matrix);
else System.Console.WriteLine("Спасибо за проверку!");
}                                                                        // Выбор проверки задания

void ReturnElement(int [,] matrix)                                       // Решение задачи №50
{
int dif = 1;
System.Console.WriteLine("Укажите строку");
int line = Convert.ToInt32(System.Console.ReadLine()) - dif;
while (line >= matrix.GetLength(0) || line < 0)
{
Console.WriteLine("Такой строки нет, укажите строку");
line = Convert.ToInt32(System.Console.ReadLine()) - dif;
}

System.Console.WriteLine("Укажите столбец");
int column = Convert.ToInt32(System.Console.ReadLine()) - dif;
while (column >= matrix.GetLength(1) || column < 0)
{
Console.WriteLine("Такого столбца нет, укажите столбец");
column = Convert.ToInt32(System.Console.ReadLine()) - dif;
}

System.Console.WriteLine(matrix[line, column]);
}                                                                        // Решение задачи №50

void ArithmeticMeanOfTheElementsInEachColumnfor(int [,] matrix)          // Решение задачи №52
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        sum = sum + matrix[i,j];
    }
    sum = sum / matrix.GetLength(0);
    sum = Math.Round(sum, 2);
   System.Console.Write(sum + " ");
}
System.Console.WriteLine();
}                                                                        // Решение задачи №52