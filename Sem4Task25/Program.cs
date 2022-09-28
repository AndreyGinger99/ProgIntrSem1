///==============================================
// # 25  Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в
//натуральную степень B.
// ==============================================
int ReadData(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

string ReadString(string line)
{
    // Выводим сообщение
    Console.WriteLine(line);
    // Считываем число
    string stroka = Console.ReadLine() ?? "0";
    return stroka;
}

void PrintResult(string line)
{
    Console.WriteLine(line);
}


int Sum(int numberA, int numberB)
{
    int number = numberA+numberB;
    //long number = (long)pow;
    return number;
}

double Division(int numberA, int numberB)
{
    double number = numberA/numberB;
    //long number = (long)pow;
    return number;
}

int Multiplication(int numberA, int numberB)
{
    int number = numberA*numberB;
    //long number = (long)pow;
    return number;
}

int Subtraction(int numberA, int numberB)
{
    int number = numberA-numberB;
    //long number = (long)pow;
    return number;
}

long Exponentiation(int numberA, int numberB)
{
    long pow = (long)Math.Pow(Convert.ToDouble(numberA), Convert.ToDouble(numberB));
    //long number = (long)pow;
    return pow;
}


ReadString("Доступны следующие действия:* / + - ^. Если понятно, нажмите Enter");
int firstNum = ReadData("Первое число:");
string action = ReadString("Действие");
int secondNum = ReadData("Второе число:");
string result = "Sorry";
    if (action=="+")
    {
        result = Sum(firstNum, secondNum).ToString();
    }
    else if (action=="-")
    {
        result = Subtraction(firstNum, secondNum).ToString();
    }
    else if(action=="/")
    {
        result = Division(firstNum, secondNum).ToString();
    }
        else if(action=="*")
    {
        result = Multiplication(firstNum, secondNum).ToString();
    }
        else if(action=="^")
    {
        result = Exponentiation(firstNum, secondNum).ToString();
    }

    PrintResult(result);