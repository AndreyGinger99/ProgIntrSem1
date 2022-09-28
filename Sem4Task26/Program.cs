///==============================================
// # 26  Напишите программу, которая принимает на вход
//число и выдаёт количество цифр в числе.
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

int IntToArrAndNumQty(int input)
{
    char[] charArray = input.ToString().ToCharArray();
    int length = charArray.Enumerable.Sum();
    return length;
}

PrintResult("количество знаков: " + IntToArrAndNumQty(ReadData("Введите число")));
