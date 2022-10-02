///==============================================
// # 40  Напишите программу, которая принимает на вход
// три числа и проверяет, может ли существовать
//треугольник с сторонами такой длины.
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

void PrintResult(string line)
{
    Console.WriteLine(line.ToString());
}

bool TriangleTest(int a, int b, int c)
{
    return (a+b>c && a+c>b && b+c>a);
}
PrintResult(
    TriangleTest(
        ReadData("Введите сторону A"),
        ReadData("Введите сторону B"),
        ReadData("Введите сторону C")
    ) ? "Такой треугольник возможен" :
        "Такого треугольника быть не может");