///==============================================
// # 17  Напишите программу, которая на вход принимает две
// координаты и определяет в какой четверти находится точка
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0)
        return 1;
    if (x < 0 && y > 0)
        return 2;
    if (x < 0 && y < 0)
        return 3;
    if (x > 0 && y < 0)
        return 4;
    return -1;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату y: ");

int res = QuarterTest(x, y);

PrintResult("Точка находится в четверти №: " + res);
