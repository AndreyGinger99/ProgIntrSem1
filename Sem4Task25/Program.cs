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

// Сложение
int Sum(int numberA, int numberB)
{
    int number = numberA+numberB;
    //long number = (long)pow;
    return number;
}

// Деление
double Division(int numberA, int numberB)
{
    double number = numberA/numberB;
    //long number = (long)pow;
    return number;
}

// Умножение
int Multiplication(int numberA, int numberB)
{
    int number = numberA*numberB;
    //long number = (long)pow;
    return number;
}

// Вычитание
int Subtraction(int numberA, int numberB)
{
    int number = numberA-numberB;
    //long number = (long)pow;
    return number;
}

// Возведение в натуральную степень
long Exponentiation(int numberA, int numberB)
{
    long pow = (long)Math.Pow(Convert.ToDouble(numberA), Convert.ToDouble(numberB));
    //long number = (long)pow;
    return pow;
}


// В зависимости от того, кокое действие выберет пользователь, 
// будет использоваться соответствующий метод
//P.S. У меня почему-то данный метод не сворачивается - нет кнопки-стрелочки
string ActionSelection(int firstNum, string action,  int secondNum)
{
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
    return result;
}

ReadString("Доступны следующие действия:* / + - ^. Если понятно, нажмите Enter");
PrintResult("Ответ: "+ActionSelection(ReadData("Первое число:"), ReadString("Действие"), ReadData("Второе число:")));