// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// void NewMatrix(int[,] matrix )
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 10);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//      }
// }

// void SotrRowInMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//      {
//         for (int k = 0; k < matrix.GetLength(1) - 1; k++)
//         {
//           if (matrix[i, k] < matrix[i, k + 1])
//           {
//             int temp = matrix[i, k + 1];
//             matrix[i, k + 1] = matrix[i, k];
//             matrix[i, k] = temp; 
//           }
           
//         }
//         Console.Write(matrix[i, j] + "\t");
//       }
//         Console.WriteLine();
//     }
// }

// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// Console.WriteLine("Начальная массив: ");
// NewMatrix(matrix);
// Console.WriteLine("Конечный массив: ");
// SotrRowInMatrix(matrix);

// // Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// void NewMatrix(int[,] matrix )
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 10);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//      }
// }

// void SotrRowInMatrix(int[,] matrix)
// {
//     int[] SumRow = new int[matrix.GetLength(0)];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//       {
//         SumRow[i] += matrix[i, j];
//       }
//     }
//     int temp = SumRow[0];
//     int num = 0;
//     for (int i = 0; i < SumRow.Length; i++)
//     {
//         if (SumRow[i] < temp)
//         {
//             temp = SumRow[i];
//             num = i + 1;
//         }
//     } 
//     Console.WriteLine("Минимальная сумма элементов в троке:" + num);
//     Console.WriteLine("Минимальная сумма элементов равна:" + temp);
// }

// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[n, m];
// Console.WriteLine("Начальная массив: ");
// NewMatrix(matrix);
// SotrRowInMatrix(matrix);

// // Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// void NewMatrix(int[,] matrix )
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = new Random().Next(-10, 10);
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//      }
// }

// void ProxMatrix(int[,] MatrixOne, int[,] MatrixTwo)
// {
//     Console.WriteLine();
//    int[,] ResultMatrix = new int [MatrixOne.GetLength(0), MatrixOne.GetLength(1)];
//    for (int i = 0; i < MatrixOne.GetLength(0); i++)
//    {
//     for (int j = 0; j < MatrixOne.GetLength(0); j++)
//       {
//        ResultMatrix[i, j] = MatrixOne[i, j] * MatrixTwo[i, j];
//        Console.Write(ResultMatrix[i, j] + "\t");
//       }
//       Console.WriteLine();
//    }
// }

// Console.Write("Введите количество строк: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int[,] MatrixOne = new int[n, m];
// int[,] MatrixTwo = new int[n, m];
// Console.WriteLine("Начальная массив 1: ");
// NewMatrix(MatrixOne);
// Console.WriteLine();
// Console.WriteLine("Начальная массив 2: ");
// NewMatrix(MatrixTwo);
// Console.WriteLine("Конечный результат: ");
// ProxMatrix(MatrixOne, MatrixTwo);

// //Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// void NewMatrix(int[,,] matrix )
// {
//      for (int i = 0; i < matrix.GetLength(0); i++)
//      {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//                matrix[i, j, k] = new Random().Next(-10, 10);            
//         }
//      }
// }

// void PrintMatrix(int[,,] MatrixOne)
// {
//      for (int i = 0; i < MatrixOne.GetLength(0); i++)
//      {
//         for (int j = 0; j < MatrixOne.GetLength(1); j++)
//         {
//             for (int k = 0; k < MatrixOne.GetLength(2); k++)
//             {
//                Console.WriteLine(MatrixOne[i, j, k] + " (" + i + ", " + j + ", " + k + ")" );
//             }
            
//         }
//      }
// }
  

// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// int[,,] MatrixOne = new int[x, y, z];
// NewMatrix(MatrixOne);
// PrintMatrix(MatrixOne);


// // Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

// int factorial(int n)
// {
//     int i, x = 1;

//     for (i=1; i <= n; i++)
//       x *= i;
//       return x;
// }
// Console.Write("Введите число элементов в основании треугольника Паскаля ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i, c;

// for (i = 0; i < n; i++)
// {
//     for (c = 0; c <= (n - i); c++)
//        Console.Write(" ");
//     for (c = 0; c <= i; c++)
//     {
//         Console.Write(" ");
//         Console.Write(factorial(i)/ (factorial(c) * factorial(i - c)));
//     }
//     Console.WriteLine();
//     Console.WriteLine();
// }
// Console.ReadLine();


// // Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// void NewMatrix(int[,] matrix )
// {
//    int temp = 1, i = 0, j = 0;
//    while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
//    {
//     matrix[i, j] = temp;
//     temp++;
//     if (i <= j + 1 && i + j < matrix.GetLength(1) -1 )
//          j++;
    
//     else if (i < j  && i + j >= matrix.GetLength(0) -1 )
//           i++;
   
//     else if (i >= j && i + j > matrix.GetLength(1) -1 )
//           j--;
//     else
//     i--;
//    }
//    for (i = 0; i < matrix.GetLength(0); i++)
//    {
//     for (j = 0; j < matrix.GetLength(1); j++)
//        Console.Write(matrix[i, j] + "\t");
//        Console.WriteLine();
//    }
// }
 

// Console.Write("Введите x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int[,] MatrixOne = new int[x, y];
// NewMatrix(MatrixOne);
