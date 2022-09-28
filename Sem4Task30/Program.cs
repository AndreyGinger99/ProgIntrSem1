///==============================================
// # 30  Напишите программу, которая выводит массив из 8
//элементов, заполненный нулями и единицами в
//случайном порядке.
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

int[] GenArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(0, 2);
        index++;
    }
    return array;
}

string ArrayToString(int[] array)
{
    return array.ToString();
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
}

PrintArray(GenArray(ReadData("Введите длинну массива")));
