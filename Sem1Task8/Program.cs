﻿///==============================================
// # 8  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// ==============================================


string? inputLineA = Console.ReadLine();

if (inputLineA != null) //Проверка на не НУЛЛ
{
    int inputNumberA = int.Parse(inputLineA); //Переводим переменную в тип integer
    int B = 0;
    while (B < inputNumberA) // Начало цикла
    {
        if (B % 2 == 0) // Проверка на четное число
        {
            Console.Write(B + ", "); // Вывод чисел
        }
        B++; //Увеличение B на единицу
    }
    Console.Write(inputNumberA); //Вывод
}