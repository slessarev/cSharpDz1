﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = int.Parse(Console.ReadLine());
if (num1>num2) Console.Write($"Число {num1} больше чем {num2}");
else
    {
        if (num1 < num2) Console.Write($"Число {num2} больше чем {num1}"); 
        else Console.Write($"Число {num2} равно  числу {num1}")            
    }