///==============================================
// # 41  Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл
// пользователь.

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

// Считаем количество чисел больше нуля
int Count(int M)
{
    int res=0;
    for (int i = 0; i < M; i++)
    {
        int num = ReadData("Введите число");
        if (num>0) res++;
    }
    return res;
}

PrintResult(Convert.ToString(Count(ReadData("Количество чисел, которое вы будете вводить? "))));


