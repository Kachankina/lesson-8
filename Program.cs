// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк массива:");
// int b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов массива:");
// int d1 = Convert.ToInt32(Console.ReadLine());

// int[,] massive = new int[b1, d1];



// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next (1, 10);
//         }
//     }
// }


// void SortToLower(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) -1 ; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     int temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArrayRandom(massive);
// PrintArray(massive);
// SortToLower(massive);
// Console.WriteLine();
// PrintArray(massive);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7



//  Console.Write("Введите количество строк массива:");
//  int b1 = Convert.ToInt32(Console.ReadLine());
//  Console.Write("Введите количество столбцов массива:");
//  int d1 = Convert.ToInt32(Console.ReadLine());

// int[,] massive = new int[b1, d1];






// void NumberRowMinSumElements(int[,] array)
// {
//     int minrow = 0;
//     int sumrow = 0;
//     int minsumrow = 0;
    
    
//     for (int i = 0; i < massive.GetLength(1); i++)
//     {
        
//         minrow += massive[0, i];
//     }
//     for (int i = 0; i < massive.GetLength(0); i++)
//     {
//         for (int j = 0; j < massive.GetLength(1); j++) sumrow += massive[i, j];
//         if (sumrow < minrow)
//         {
//             minrow  = sumrow;
//             minsumrow = i;
//         }
//         sumrow = 0;
//     }
//     Console.Write($"{minsumrow + 1} строка");
// }


// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }


// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }
// FillArrayRandom(massive);
// PrintArray(massive);
// Console.WriteLine();
// NumberRowMinSumElements(massive);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.



// int rows = ReadInt("Введите количество строк: ");
// int columns = ReadInt("Введите количество столбцов: ");
// int[,] array = new int[rows, columns];
// int[,] secondArray = new int[rows, columns];
// int[,] resultArray = new int[rows, columns];



// if (array.GetLength(0) != secondArray.GetLength(1))
// {
//     Console.WriteLine(" Нельзя перемножить ");
//     return;
// }
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < secondArray.GetLength(1); j++)
//     {
//         resultArray[i, j] = 0;
//         for (int k = 0; k < array.GetLength(1); k++)
//         {
//             resultArray[i, j] += array [i, k] * secondArray[k, j];
//         }
//     }
// }

// PrintArray2D(resultArray);



// // Функция ввода
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция заполнения массива рандомными числами от 1 до 9
// void FillArrayRandom(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 10);
//         }
//     }
// }

// // Функция вывода двумерного массива в терминал 
// void PrintArray2D(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }
// FillArrayRandom(array);
// PrintArray2D(array);

// Console.WriteLine();

// FillArrayRandom(secondArray);
// PrintArray2D(secondArray);

// Console.WriteLine();