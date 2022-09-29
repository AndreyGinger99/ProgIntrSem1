///==============================================
// # 31  Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных и положительных
//элементов массива.
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
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
}

// Суммируем положительные и отрицательные значения массива
int[] NegativePositiveSums(int[] array)
{
    int[] sums = new int[2];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sums[0] += array[i];
        }
        else
        {
            sums[1] += array[i];
        }
    }
    return sums;
}

int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите нижнюю границу");
int topBorder = ReadData("Введите верхнюю границу");

int[] inputArray = GenArray(arrayLength, downBorder,topBorder);

int[] sumArray = NegativePositiveSums(inputArray);

Print1DArray(inputArray);
PrintResult("Сумма > 0: "+sumArray[0]+ " Сумма <0: " +sumArray[1]);
Print1DArray(sumArray);



