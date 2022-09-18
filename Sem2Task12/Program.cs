//-------------------------------------------------
//              Задача 12
// Напишите программу, которая будет принимать на вход два числа и
// выводить, является ли второе число кратным первому. Если оно не кратно, 
// то программа выводит остаток от деления
//------------------------------
string? firstNum = Console.ReadLine();
string? secondNum = Console.ReadLine();

if (firstNum != null&&secondNum != null)
{
    Console.WriteLine("пока норм идет");
    int firstNumNumber = int.Parse(firstNum);
    int secondNumNumber = int.Parse(secondNum);
    Console.WriteLine(firstNumNumber % secondNumNumber == 0 ? "Кратно" : (int)firstNumNumber % (int)secondNumNumber);

}
