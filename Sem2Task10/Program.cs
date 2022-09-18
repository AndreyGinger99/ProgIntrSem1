//--------------------Задача 10----------------------------
// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
///--------------------------------

//Получаем значение
string threeDigitNumber = Console.ReadLine();

// Проверяем на НЕ нулл и на длину строки
if (threeDigitNumber != null && threeDigitNumber.Length == 3)
{
    //Создаем массив из введенного числа и выводим результат
    char[] charArray = threeDigitNumber.ToString().ToCharArray();
    Console.Write(charArray[1]);
}
