///==============================================
// # 37  Найдите произведение пар чисел в одномерном
// массиве. Парой считаем первый и последний
// элемент, второй и предпоследний и т.д. Результат
// запишите в новом массиве.
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

// Создаем массив из пар первых и последних элементов массива
int[] ArrayWithMultiplicatedElems(int[] array)
{
    // Находим середину массива/длину нового массива
    int arrayMultiLength = array.Length/2;
    // Создаем новый массив с длиной, равно половине исходного массива
    int[] arrayMultiplication = new int[array.Length/2];
    int index = 0;
    while (index <arrayMultiplication.Length )
    {
        arrayMultiplication[index] = array[index]*array[array.Length-1-index];
        index++;
    }
    return arrayMultiplication;
}

int[] inputArray = GenArray(12, 3, 10);
// Выводим изначальный массив
Print1DArray(inputArray);
// Добавляем пустую строку
Console.WriteLine();
// Выводим новый массив
Print1DArray(ArrayWithMultiplicatedElems(inputArray));


