// Задача 9
// Напишите программу, которая выводит случайное число из отрезка [10, 99)
// и показывает наибольшуюю цифру числа.
//-----------------------------------------------------------

void myVariant()
{
    Console.WriteLine("Метод 1");
    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    // Вариант 1
    if (firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }
}

void evgenVariant()
{
    Console.WriteLine("Метод 2");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    // Вариант Евгения
    Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
}

void charVariant()
{
    Console.WriteLine("Метод 3");

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(10, 100);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;
    //Вариант char
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine((int)charArray[0] > (int)charArray[1] ? charArray[0] : charArray[1]);
    Console.Write("Что же содержится у нас в массиве?? " + charArray[0] + charArray[1]);
}

myVariant(); evgenVariant();
charVariant();