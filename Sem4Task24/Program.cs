///==============================================
// # 24  Напишите программу, которая принимает на
// вход число A и выдает сумму чисел от 1 до A.
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

int VariantSumSimple(int numberA)
{
    int sum = 0;
    for (int i = 1; i < numberA; i++)
    {
        sum += i;
    }
    return sum + numberA;
}

string IntToString(int numberA)
{
    string line = numberA.ToString();
    return line;
}

//int num = ReadData("Введите число N: ");

PrintResult(IntToString(VariantSumSimple(ReadData("Введите число"))));
//PrintResult(LineNumbers(num, 3));
