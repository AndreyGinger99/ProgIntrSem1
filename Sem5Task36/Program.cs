///==============================================
// # 36  Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
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

//Находим сумму элементов на нечетных местах
int OddPositionValueSum(int[] array)
{
    int elemSum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
            elemSum = elemSum + array[i];
    }
    return elemSum;
}

//Находим количество элементов на нечетных местах
int OddPositionValueQty(int[] array)
{
    int elemQty = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0)
            elemQty++;;
    }
    return elemQty;
}

//Выведем все пары элементов в массиве
void PrintArrayPairs(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i+1; j < array.Length; j++)
        {
            Console.WriteLine(array[i]+" | "+ array[j]);
        }
    }
}
int arrayLength = ReadData("Введите длину массива");
int downBorder = ReadData("Введите нижнюю границу");
int topBorder = ReadData("Введите верхнюю границу");

int[] inputArray = GenArray(arrayLength, downBorder, topBorder);
Print1DArray(inputArray);

Console.WriteLine("\n Сумма элементов на нечетных позициях: " + OddPositionValueSum(inputArray)
+ "\n Количество элементов на нечетных позициях: "+ OddPositionValueQty(inputArray));
PrintArrayPairs(inputArray);




using System;
namespace InsertionSortDemo {
   class Example {
      static void Main(string[] args) {
         int[] arr = new int[10] { 23, 9, 85, 12, 99, 34, 60, 15, 100, 1 };
         int n = 10, i, j, val, flag;
         Console.WriteLine("Insertion Sort");
         Console.Write("Initial array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
         for (i = 1; i < n; i++) {
            val = arr[i];
            flag = 0;
            for (j = i - 1; j >= 0 && flag != 1; ) {
               if (val < arr[j]) {
                  arr[j + 1] = arr[j];
                  j--;
                  arr[j + 1] = val;
               }
               else flag = 1;
            }
         }
         Console.Write("\nSorted Array is: ");
         for (i = 0; i < n; i++) {
            Console.Write(arr[i] + " ");
         }
      }
   }
}