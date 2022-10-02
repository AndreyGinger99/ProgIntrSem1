///==============================================
// # 44  Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
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

void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

string FibNum(int num)
{
    string res = "";
    int first = 0;
    int last = 1;
    int buff = 0;
    for (int i = 0; i < num; i++)
    {
        res = res + "," + last;
        buff = first + last;
        first = last;
        last = buff;
        Console.WriteLine(last + " ");
    }
    return last.ToString();
}

// Метод решения с через массив
int[] Fibonacci(int num)
{
    int[] fibonacciArray = new int[num];
    fibonacciArray[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
    }
    return fibonacciArray;
}

PrintResult(FibNum(ReadData("Введите число:")));
Print1DArray(Fibonacci(ReadData("Введите число:")));
