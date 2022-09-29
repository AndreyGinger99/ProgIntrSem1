///==============================================
// # 30  Напишите программу, которая задаёт
// массив из 8 элементов и выводит их на экран.
//* Ввести с клавиатуры длину массива и диапазон значений элементов
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


//Метод, задающий длину массива и заполняющий его значениями от <startNum> до <endNum> включительно
int[] GenArray(int arrayLength, int startNum, int endNum)
{
    int[] array = new int[arrayLength];
    int index = 0;
    while (index < array.Length)
    {
        array[index] = new Random().Next(startNum, endNum+1);
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


// Печать массива
//PrintArray(GenArray(ReadData("Введите длинну массива"), ReadData("Введите начальное значение"), ReadData("Введите Конечное значение")));



//* дополнительная задача: Написать программу которая из имен через запятую выберет случайное
//имя и выведет в терминал
//Игорь, Антон, Сергей -> Антон


string names = "Андрей, Георгий, Евгений, Адамантий, Сергей, Анатолий";

string[] stringArray(string inputData)
{
    string[] names = inputData.Split(", ");
    return names;
}

string RandomName(string[] array)
{
   //int rndNum = new Random.Next(1,length+1);
    string rndName = array[new Random().Next(0,array.Length)];
    return rndName;
}
PrintResult(RandomName(stringArray(names)));


