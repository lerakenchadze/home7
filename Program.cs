// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//  m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] Create2dArray(int rows, int cols, int min, int max)
// {
//     double [,] array = new double [rows,cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().NextDouble() * (max-min);
//         }
//     }
//     return array;
// }

// void ShowArray(double [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double [,] array = Create2dArray(m,n,min,max);
// ShowArray(array);



// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int [,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int [,] array = new int [rows,cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }


// void ShowArray(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j]+ " ");
//         }
//     Console.WriteLine();
//     }
// }


// void Index(int[,] array, int i, int j)
// {
//     if (i < array.GetLength(0) && j < array.GetLength(1))
//         Console.Write($" значение этого элемента :=  {array[i,j]}");
//     else
//         Console.Write($" такого числа в массиве нет  {array[i,j]}");

// } 

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n,min,max);
// Console.Write("Enter row: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter col: ");
// int j = Convert.ToInt32(Console.ReadLine());
// ShowArray(array);
// Index(array, i, j);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int [,] Create2dArray(int rows, int cols, int min, int max)
{
    int [,] array = new int [rows,cols];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i,j] = new Random().Next(min,max+1);
        }
    }
    return array;
}


void ShowArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+ " ");
        }
    Console.WriteLine();
    }
}


void FindMiddle(int[,] array)
{
     for (int j = 0; j< array.GetLength(1); j++){

        double summ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
          summ = summ+array[i,j];

        }
       Console.WriteLine($"Среднее арифметическое №{j} столбца: {Math.Round((summ/array.GetLength(0)),1)} ");
    }

} 

Console.Write(" Enter m:= ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter n:= ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter min elem:= ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter max elem := ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write(" Enter elem i:= ");

int[,] array = Create2dArray(n, m, min, max);
ShowArray(array);
FindMiddle(array);
