///==============================================
// # 18  Напишите программу, которая по заданному номеру четверти
// показывает диапазон возможных координат в этой четверти
// =============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string QuarterBorderAsk(int numQuarter)
{
    if (numQuarter == 1)
        return "x>0 y>0";
    if (numQuarter == 2)
        return "x<0 y>0";
    if (numQuarter == 3)
        return "x<0 y<0";
    if (numQuarter == 4)
        return "x>0 y<0";

    return "-1";
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int num = ReadData("Введите номер четверти: ");

string res = QuarterBorderAsk(num);

PrintResult(res);
