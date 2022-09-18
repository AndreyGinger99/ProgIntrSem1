//-------------------------------------------------
//                  Задача 11
// Напишите программу, которая выводит случайное трехзначное число и
// удаляет вторую цифру этого числа, а потом выводит его пользователю
//------------------------------

    System.Random numberGenerator = new System.Random();

    int number = numberGenerator.Next(100, 1000);

    Console.WriteLine(number);

    int firstDigit = number / 10;
    int secondDigit = number % 10;

    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(charArray[0]+" "+charArray[2]);
    Console.WriteLine(charArray);
