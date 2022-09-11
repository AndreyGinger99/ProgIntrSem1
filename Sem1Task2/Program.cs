///==============================================
// # 2 Напишите программу, которая на вход принимает два числа
// и выдает какое больше, какое меньше
// ==============================================
string? inputLineA = Console.ReadLine();    //Вводим числа
string? inputLineB = Console.ReadLine();

if (inputLineA != null && inputLineB != null) //Проверка на не НУЛЛ
{

    int inputNumberA = int.Parse(inputLineA); // Переводим в integer
    int inputNumberB = int.Parse(inputLineB);

    //int outNumber = 0;
    if (inputNumberA > inputNumberB) // Проверяем больше ли число А чем число Б
    {
        Console.WriteLine("Число "); // Выводим если больше
        Console.WriteLine(inputNumberA);
        Console.WriteLine(" больше чем  ");
        Console.WriteLine(inputNumberB);
    }
    else 
    {
        Console.WriteLine("Число "); // Выводим если меньше
        Console.WriteLine(inputNumberB);
        Console.WriteLine(" больше чем  ");
        Console.WriteLine(inputNumberA);
    }

    
}
