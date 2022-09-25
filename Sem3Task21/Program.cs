///==============================================
// # 21  Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
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
    Console.WriteLine(line);
}
double DistanceBetweenTwoDots(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
    //int distance = (int)dist;
}

int x1 = ReadData("Введите координату x 1: ");
int y1 = ReadData("Введите координату y 1: ");
int z1 = ReadData("Введите координату z 1: ");
int x2 = ReadData("Введите координату x 2: ");
int y2 = ReadData("Введите координату y 2: ");
int z2 = ReadData("Введите координату z 2: ");


//double res = DistanceBetweenTwoDots(x1, y1, x2, y2);
//int res = QuarterTest(x, y);

PrintResult("Расстояние: " + Math.Round(DistanceBetweenTwoDots(x1, y1,z1, x2, y2, z2), 2));
