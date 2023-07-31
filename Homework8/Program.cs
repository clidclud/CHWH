// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// System.Console.WriteLine("Введите кол-во строк");
// int lines = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(System.Console.ReadLine());

// int [,] matrix = new int [lines,columns];

// System.Console.WriteLine();
// ArrayGeneration();
// PrintArray();
// System.Console.WriteLine();
// OrderingArrayElements();
// PrintArray();

// void ArrayGeneration()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(0,10);
//         }
//     }
// }

// void OrderingArrayElements()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//             {
//                 if (matrix[i,j] > matrix[i,k])
//                 {
//                     int temp = matrix[i,j];
//                     matrix[i,j] = matrix[i,k];
//                     matrix[i,k] = temp;
//                 }
//             }
//         }
//     }
// }

// void PrintArray()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i,j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// System.Console.WriteLine("Введите кол-во строк");
// int lines = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов");
// int columns = Convert.ToInt32(System.Console.ReadLine());

// int[,] matrix = new int[lines, columns];

// System.Console.WriteLine();
// ArrayGeneration();
// System.Console.WriteLine();
// TheSmallestSumOfElements();

// void ArrayGeneration()
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(0, 10);
//             System.Console.Write(matrix[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void TheSmallestSumOfElements()
// {
//     int minSum = 0;
//     int minString = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum += matrix[i, j];
//         }
//         if (minSum == 0) minSum = sum;
//         if (sum <= minSum) 
//         {
//         minSum = sum;
//         minString = i +1;
//         }
//     }
//     System.Console.WriteLine("Наименьшая сумма элементов: " + minSum);
//     System.Console.WriteLine("Номер строки с наименьшей суммой элементов: " + minString);
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// System.Console.WriteLine("Введите кол-во строк первого массива");
// int lines1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов первого массива");
// int columns1 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кол-во строк второго массива");
// int lines2 = Convert.ToInt32(System.Console.ReadLine());
// System.Console.WriteLine("Введите кол-во столбцов второго массива");
// int columns2 = Convert.ToInt32(System.Console.ReadLine());

// int[,] matrix1 = new int[lines1, columns1];
// int[,] matrix2 = new int[lines2, columns2];
// int[,] resultMatrix = new int[lines1, columns2];

// if (lines1 == columns2 || lines2 == columns1)
// {
//     System.Console.WriteLine();
//     ArrayGeneration(matrix1);
//     PrintArray(matrix1);
//     System.Console.WriteLine();
//     ArrayGeneration(matrix2);
//     PrintArray(matrix2);
//     System.Console.WriteLine();
//     ProductOfTwoMatrices();
//     PrintArray(resultMatrix);
//     System.Console.WriteLine();
// }
// else
// {
//     System.Console.WriteLine("Количество столбцов первой матрицы должно равняться количеству строк второй.");
// }

// void ArrayGeneration(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             System.Console.Write(array[i, j] + " ");
//         }
//         System.Console.WriteLine();
//     }
// }

// void ProductOfTwoMatrices()
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < matrix1.GetLength(1); k++)
//             {
//                 sum += matrix1[i, k] * matrix2[k, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
// }

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x = 2;

// int [,,] array = new int [x, x, x];

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         for (int k = 0; k < array.GetLength(2); k++)
//         {
//             array [i, j, k] = new Random().Next(10, 100);
//             System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
//         }
//         System.Console.WriteLine();
//     }  
// }

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int x = 4;

// int[,] matrix = new int[x, x];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
// {
//   matrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= matrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > matrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// PrintArray();

// void PrintArray()
// {
//   for (int i = 0; i < matrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//       if (matrix[i,j] / 10 <= 0)
//       Console.Write($" {matrix[i,j]} ");

//       else Console.Write($"{matrix[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }