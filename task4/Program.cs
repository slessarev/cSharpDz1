﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
if (N<0) //проверка на отрицательное значение
    {
        int i=N;
        while (i <=1)
            {
                if (i % 2 == 0) Console.Write($"{i}, "); //проверка четности. Если да - то выводим
                i++; 
            }
    }
else
    {
        int i=2;
        while (i<=N)
        {
            Console.Write($"{i}, ");
            i+=2;
        }
    }