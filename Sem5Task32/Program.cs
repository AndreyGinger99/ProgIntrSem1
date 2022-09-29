///==============================================
// # 32  Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
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

void PrintResult(string line)
{
    Console.WriteLine(line);
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
    Console.Write(array[array.Length - 1]+"]");
}

//Суммируем положительные и отрицательные значения массива
int[] ReverseSign(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        //Console.WriteLine("Ориг "+ array[i]);
        array[i] *= -1;
        //Console.WriteLine("НЕ Ориг "+ array[i]);

    }
    return array;
}


int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите нижнюю границу");
int topBorder = ReadData("Введите верхнюю границу");

int[] inputArray = GenArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);

int[] sumArray = ReverseSign(inputArray);
// Если вывести в консоль массив inputArray после формирования
// массива sumArray, то они будут идентичными. Почему может такое происходить?
// Неужели sumArray изменяет inputArray?
Console.WriteLine();
Print1DArray(sumArray);



