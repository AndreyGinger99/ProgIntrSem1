//--------------------------------------
// Напишите программу, которая принимает на вход число
//и проверяет кратно ли оно одновременно 7 и 23 
//-----------------------
string? inputLine = Console.ReadLine();   
int number = int.Parse(inputLine);
if (number % 7 == 0 && number % 23 == 0)
{ 
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("НЕ КРАТНО");
}
