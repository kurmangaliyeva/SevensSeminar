﻿using System;

namespace SevensSeminar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            // m = 3, n = 4.
            // 0,5 7 -2 -0,2
            // 1 -3,3 8 -9,9
            // 8 7,8 -7,1 9

            /*   
            Console.WriteLine($"Задача 47: Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

            Console.Write("Введите m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Console.WriteLine($"m = {m}, n = {n}.");

            double[,] array = new double[m, n];

            CreateArrayDouble(array);

            WriteArray(array);

            Console.WriteLine();

            void CreateArrayDouble(double[,] array)
            {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                array[i, j] = new Random().NextDouble() * 20 - 10;
                }
            }
            }

            void WriteArray (double[,] array){
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    double alignNumber = Math.Round(array[i, j], 1);
                    Console.Write(alignNumber + " ");
                }
                Console.WriteLine();
            } }
            
            */

            /* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            17 -> такого числа в массиве нет */

            
            void FindElement(int[,] array, int posRows, int posColums){
                if (posRows < array.GetLength(0) && posColums < array.GetLength(1))
                    Console.Write(array[posRows, posColums]);
                else Console.Write("Такого числа нет");
            }


            int[,] array = new int[,]{
                {1, 4, 7, 2},
                {5, 9, 2, 3},
                {8, 4, 2, 4},
                {4, 5, 7, 2}
            };

            Console.Write("Введите строку: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите столбец: ");
            int colums = Convert.ToInt32(Console.ReadLine());

            FindElement(array, rows, colums);







        


        
    }
} 

}
