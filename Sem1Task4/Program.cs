///==============================================
// # 4  Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
// ==============================================


string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();
string? inputLineC = Console.ReadLine();

if (inputLineA != null && inputLineB != null && inputLineC != null) //Проверка на не НУЛЛ
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    int inputNumberC = int.Parse(inputLineC);
    int maxNum = inputNumberA;
    if (inputNumberB > maxNum)
    { 
        maxNum = inputNumberB;
        if (inputNumberC > maxNum)
        { 
        maxNum = inputNumberC;
        }
    }
    else 
    if (inputNumberC > maxNum)
    { 
        maxNum = inputNumberC;
    }
    Console.WriteLine("Число ");
    Console.WriteLine(maxNum);
    Console.WriteLine(" наибольшее");


}
   