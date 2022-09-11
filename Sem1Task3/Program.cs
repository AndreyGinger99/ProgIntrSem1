///==============================================
// # 3 Напишите программу, которая будет выдавать
// название дня недели по заданному номеру
// ==============================================
string? inputLine = Console.ReadLine();

if (inputLine != null)
{
    int inputDayOfWeek = int.Parse(inputLine);
    // string[] dayOfweek = new string[7];
    // dayOfweek[0] = "Понедельник";
    // dayOfweek[1] = "Вторник";
    // dayOfweek[2] = "Среда";
    // dayOfweek[3] = "Четверг";
    // dayOfweek[4] = "Пятница";
    // dayOfweek[5] = "Суббота";
    // dayOfweek[6] = "Воскресенье";

    // if (inputDayOfWeek > 7 || inputDayOfWeek < 1)
    // {
    //     Console.WriteLine("Такого дня не бывает");
    // }
    // else
    // {
    //     Console.WriteLine(dayOfweek[inputDayOfWeek - 1]);
    // }
     string outDayOfWeek = string.Empty; //""
    // switch(inputDayOfWeek)
    // {
    //     case 1: outDayOfWeek="Понедельник"; break;
    //     case 2: outDayOfWeek="Вторник"; break;
    //     case 3: outDayOfWeek="Среда"; break;
    //     case 4: outDayOfWeek="Четверг"; break;
    //     case 5: outDayOfWeek="Пятница"; break;
    //     case 6: outDayOfWeek="Суббота"; break;
    //     case 7: outDayOfWeek="Воскресенье"; break;
    //     default: outDayOfWeek="Такого дня недели нет"; break;
    // }
    outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(inputDayOfWeek));
    
    
     Console.WriteLine(outDayOfWeek);
}

