//--------------------Задача 13----------------------------
// Напишите программу, которая выводит третью цифру заданного
//  числа или сообщает, что третьей цифры нет.
///--------------------------------

//Получаем значение
string someDigitNumber = Console.ReadLine();

// Проверяем на НЕ нулл и на длину строки
if (someDigitNumber != null && someDigitNumber.Length >= 3)
{
    //Создаем массив из введенного числа и выводим результат
    char[] charArray = someDigitNumber.ToString().ToCharArray();
    Console.Write(charArray[2]);
}
else 
{
    Console.Write("Третьей цифры нет.");
}
