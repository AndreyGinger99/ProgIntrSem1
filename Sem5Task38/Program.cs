///==============================================
// # 38  Задайте массив вещественных чисел.
// Найдите разницу между максимальным и 
// минимальным элементов массива.
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
double[] GenArray(int arrayLength, int downBorder, int topBorder)
{
    // Создаем массив
    double[] array = new double[arrayLength];

    // Проверяем условие - нижняя граница < верхней границы
    int index = 0;
    if (downBorder < topBorder)
    {
        // Заполняем массив
        while (index < array.Length)
        {
            array[index] =Math.Round((new Random().NextDouble()) + new Random().Next(downBorder, topBorder + 1), 2);
            index++;
        }
    }
    // Вовзвращаем результат
    return array;
}

// Печатаем одномерный массив
void Print1DArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

// Сортируем массив пузырьком
double[] BubbleSort(double[] array) 
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i+1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        double temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition]=temporary;
    }
    return array;
}

//Сортировка методом вставки
double[] InsertionSort(double[] array){
	int counter=0;
	for(int i=1;i<array.Length;i++){
		for(int j=i; j>0 && array[j-1]>array[j];j--){
			counter++;
			double tmp=array[j-1];
			array[j-1]=array[j];
			array[j]=tmp;
		}
	}
    return array;
}


double MinMaxValueDelta (double[] array)
{
    return Math.Round(array[array.Length-1]-array[0], 2);
}

double[] inputArray = GenArray(12, 3, 10);
 // Выводим изначальный массив
 Print1DArray(inputArray);
 Console.WriteLine();
 // Выводим отсортированный методом вставки массив 
Console.WriteLine("Сортировка методом вставки");
 Print1DArray(InsertionSort(inputArray));
 
Console.WriteLine("Сортировка методом пузырька");
 // Выводим отсортированный методом пузырька массив массив
 Print1DArray(BubbleSort(inputArray));
 
 // Выводим разницу между максимальным и минимальным значением
 Console.WriteLine("\n Разница между максимальным и минимальным значением массива:"
 + MinMaxValueDelta(InsertionSort(inputArray)));



