///==============================================
// # 34  Задайте массив заполненный случайными
// положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// ==============================================
// Ввод данных
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

//Проверяем четность элементов массива
bool EvenValueCheck(int element)
{
    return element % 2 == 0 ? true : false;
}

// Сортируем массив методом пузырька
int[] ArraySort(int[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;
    }
    return array;
}
//Находим количество четных элементов
int EvenValueQty(int[] array)
{
    int elemQty = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (EvenValueCheck(array[i]))
            elemQty++;
        //if (array[i] >= 10 && array[i] <= 99)
        //{
        //    elemQty++;
        //}
    }
    return elemQty;
}

int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите нижнюю границу");
int topBorder = ReadData("Введите верхнюю границу");

int[] inputArray = GenArray(arrayLength, downBorder, topBorder);
Print1DArray(ArraySort(inputArray));

Console.WriteLine("\n Количество четных элементов: " + EvenValueQty(ArraySort(inputArray)));
