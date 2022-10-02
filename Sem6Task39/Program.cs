///==============================================
// # 39  Напишите программу, которая перевернёт
// одномерный массив (последний элемент будет на
// первом месте, а первый - на последнем и т.д.)
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Универсальный метод генерации и заполнения массива
int[] GenArray(int arrayLength, int downBorder, int topBorder)
{
    // Создаем массив
    int[] array = new int[arrayLength];

    // Проверяем условие - нижняя граница < верхней границы
    int index = 0;
    if (downBorder < topBorder)
    {
        // Заполняем массив
        while (index < array.Length)
        {
            array[index] = new Random().Next(downBorder, topBorder + 1);
            index++;
        }
    }
    // Вовзвращаем результат
    return array;
}

// Печатаем одномерный массив
void Print1DArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

void ReverseCurrentArray(int[] array)
{
    int temp;
    for (int i = 0; i <= (array.Length/2); i++)
    {
        temp = array[i];
        array[i]=array[array.Length-1-i];
        array[array.Length-1-i] = temp;
    }
}

int[] ReverseArrayIntoNew(int[] array)
{
    int temp;
    int[] outArray = new int[array.Length];
    for (int i = 0; i <= (array.Length/2); i++)
    {
        temp = array[i];
        outArray[i]=array[array.Length-1-i];
        outArray[array.Length-1-i] = temp;
    }
    return outArray;
}

int[] inputArray = GenArray(13, 3, 10);
Print1DArray(inputArray);
int[] ReversedArray = ReverseArrayIntoNew(inputArray);

Console.WriteLine();
Print1DArray(ReversedArray);

Console.WriteLine();
Print1DArray(inputArray);








