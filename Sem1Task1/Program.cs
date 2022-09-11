///==============================================
// # 2 Напишите программу, которая на вход принимает два числа
// и проверяет является ли первое число квадратом второго
// ==============================================
string? inputLineA = Console.ReadLine();
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null)
{
    int inputNumberA = int.Parse(inputLineA);
    int inputNumberB = int.Parse(inputLineB);
    //int outNumber = 0;

    //bool outResult = (inputNumberA * inputNumberA == inputNumberB);
    bool outResult = (Math.Sqrt(inputNumberB) == inputNumberA);

    //int outNumber = inputNumber * inputNumber;
    //int outNumber = (int)Math.Pow(inputNumber,2);

    Console.WriteLine(outResult);
}
