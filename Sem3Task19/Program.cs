///==============================================
// # 19  Напишите программу, которая принимает на вход пятизначное
// число и проверяет, является ли оно палиндромом.
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Было принято решение использовать тип long, 
//так как длина палиндрома может быть любой
long ReadDataLong(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    long number = long.Parse(Console.ReadLine() ?? "0");
    return number;
}
void PrintResult(string line)
{
    Console.WriteLine(line);
}
string BoolToString(bool boolean)
{
    string res = boolean.ToString();
    return res;
}
// Первый вариант решения (через деление на 1000 и на 100)
bool PolindromeTestFirst(int poli)
{
    return poli/10000==poli%10 && poli/1000%10==poli/10%10 ?  true :  false;
}
//Второй вариант решения для палиндрома любой длины
bool IntToArrAndPalindromeCheck(long input)
{
    char[] charArray = input.ToString().ToCharArray();
    int length = charArray.Length;
    bool paliCheck = false;
    for (int i = 0; i < length/2+1; i++)
    {
        if (charArray[i]==charArray[length-1-i])
        {
            paliCheck = true;
        }
        else
        {
            paliCheck = false;
            break;
        }
    }
    return paliCheck;
}
PrintResult(
    BoolToString(
        PolindromeTestFirst(
            ReadData("Введите число для первого варианта: "))));

PrintResult(
    BoolToString(
        IntToArrAndPalindromeCheck(
            ReadDataLong("Введите число для второго варианта: "))));