///==============================================
// # 42  Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.
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

double[] BitConvert(double k1, double b1, double k2, double b2)
{
    //int x,y;
    double[] array = new double[2];
    double x = (b2 - b1) / (k1 - k2);
    Console.WriteLine(" k1: " + k1);
    Console.WriteLine(" b1: " + b1);
    Console.WriteLine(" k2: " + k2);
    Console.WriteLine(" b1: " + b2);

    double y = k1 * x + b1;
    array[0] = (b2 - b1) / (k1 - k2);
    array[1] = k1 * array[0] + b1;
    return array;
}

// Печатаем одномерный массив
void Print1DArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
}

double TriangleSquare(double x1, double x2, double x3, double y1, double y2, double y3)
{
    return 0.5 * ((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
}

// Пересечение первой и второй прямой
double[] abIntersection = BitConvert(5, 2, 9, 4);

// Пересечение второй и третьей прямой
double[] bcIntersection = BitConvert(9, 4, 10, 3);

// Пересечение первой и третьей прямой
double[] acIntersection = BitConvert(5, 2, 10, 3);
Console.WriteLine();
Print1DArray(abIntersection);
Console.WriteLine();
Print1DArray(bcIntersection);
Console.WriteLine();
Print1DArray(acIntersection);
Console.WriteLine();

PrintResult(
    Convert.ToString(
        TriangleSquare(
            abIntersection[0],
            bcIntersection[0],
            acIntersection[0],
            abIntersection[1],
            bcIntersection[1],
            acIntersection[1]
        )
    )
);
