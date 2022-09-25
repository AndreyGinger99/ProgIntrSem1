﻿///==============================================
// # 23  Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}

string LineNumbers(int numberN, int pow)
{
    string outLine = string.Empty;
    for (int i = 1; i < numberN; i++)
    {
        outLine = outLine + Math.Pow(i, pow) + "\t";
    }
    outLine = outLine + Math.Pow(numberN, pow);
    return outLine;
}
//string LineSquare(int numberN, int pow)
// {
//     string outLine = string.Empty;
//     for (int i = 1; i < numberN; i++)
//     {
//         outLine = outLine + Math.Pow(i, pow) + "\t";
//     }
//     outLine = outLine + Math.Pow(numberN, pow);
//      return outLine;
// }

int num = ReadData("Введите число N: ");

PrintResult(LineNumbers(num, 1));
PrintResult(LineNumbers(num, 3));
