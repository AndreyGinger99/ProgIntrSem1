///==============================================
// # 28  Напишите программу, которая принимает на вход
//число N и выдаёт произведение чисел от 1 до N.
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

long MultA(int input)
{
    long mult = 1;
    for (int i = 1; i <= input; i++)
    {
        mult = mult * i;
    }

    return mult;
}

PrintResult("количество знаков: " + MultA(ReadData("Введите число")));
