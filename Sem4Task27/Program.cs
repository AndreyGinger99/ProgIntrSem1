///==============================================
// # 27 Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

//Считаем сумма чисел в введенном числе
int DigitSum(int number)
{
    int sum = 0;
    while (number > 0) 
    {
        sum += number%10;
        number = number/10;
    }
    return sum;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}

PrintResult("Сумма чисел: " + DigitSum(ReadData("Введите число: ")));
