﻿///==============================================
// # 16  Напишите программу, которая на вход принимает два числа и 
// проверяет является ли одно число квадратом другого.
// ==============================================
int ReadData (string line)
{
    // Выводим сообщение 
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine()??"0");
    return number;
}
// Тнст на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (firstNum==secondNum*secondNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//Вывод данных
void PrintData (int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum)==true)
    {
        Console.WriteLine("Число "+ firstNum + " квадрат числа " + secondNum);
    }
    else
    {
        Console.WriteLine("Число "+ firstNum + " НЕ квадрат числа " + secondNum);
    }
}

int num1 = ReadData("Введите число 1: ");
int num2 = ReadData("Введите число 2: ");
PrintData(num1, num2);
PrintData(num2, num1);