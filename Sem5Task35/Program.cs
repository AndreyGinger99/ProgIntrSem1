///==============================================
// # 35  Задайте одномерный массив из 123 случайных
// чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10,99].
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

//Проверяем условие - элемент в отрезке [10, 99]
bool ElemInSegmentCheck (int element)
{
    return element >= 10 && element <= 99 ? true : false;
}
//Находим количество элементов в отрезке [10, 99]
int ElemQtyInSegment(int[] array)
{
    int elemQty = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (ElemInSegmentCheck(array[i]))
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
Print1DArray(inputArray);

Console.WriteLine("\n Количество элементов: "+ElemQtyInSegment(inputArray));


