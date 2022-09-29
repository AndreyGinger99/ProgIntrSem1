///==============================================
// # 33  Напишите программу, которая
//определяет, присутствует ли заданное число в
//массиве.

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

//Находим позицию искомого числа в массиве
int FindElementPosition(int[] array, int elemThatWeSearch)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemThatWeSearch)
        {    
            return i;
            break;
        }
    }
    return -1;
}

bool FindElementBool(int[] array, int elemThatWeSearch)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemThatWeSearch)
        {    
            return true;
            break;
        }
    }
    return false;
}
// вывод ответа
void PrintAnswer(bool answer)
{
    Console.WriteLine(answer ? "Да" : "Нет");
}

int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите нижнюю границу");
int topBorder = ReadData("Введите верхнюю границу");

int[] inputArray = GenArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);

Console.WriteLine("Элемент найден на позиции: "+FindElementPosition(inputArray, ReadData("\n Введите искомое число")));

PrintAnswer(FindElementBool(inputArray, ReadData("\n Введите искомое число")));

