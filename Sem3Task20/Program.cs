///==============================================
// # 20  Напишите программу, которая на вход принимает две
// координаты и находит расстояние между ними в 2д пространстве
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
double DistanceBetweenTwoDots(int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1)));
    //int distance = (int)dist;
}


int x1 = ReadData("Введите координату x 1: ");
int y1 = ReadData("Введите координату y 1: ");
int x2 = ReadData("Введите координату x 2: ");
int y2 = ReadData("Введите координату y 2: ");


//double res = DistanceBetweenTwoDots(x1, y1, x2, y2);
//int res = QuarterTest(x, y);

PrintResult("Расстояние: " + Math.Round(DistanceBetweenTwoDots(x1, y1, x2, y2), 2));
