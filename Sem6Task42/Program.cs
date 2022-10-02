///==============================================
// # 42  Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
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
    Console.WriteLine(line.ToString());
}

string BitConvert(int A)
{
    string res = String.Empty;
    while (A > 0)
    {
        res =  A % 2 + res;
        A=A/2;
    }

    return res;
}

PrintResult("Искомое число: "+BitConvert(ReadData("Введите число")));