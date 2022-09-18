///==============================================
// # 15  Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет,
// является ли этот день выходным.
// ==============================================
string? inputLine = Console.ReadLine();
//Добавляем словарь с днями недели
Dictionary<string, int> dayOfWeeks = new Dictionary<string, int>();
dayOfWeeks.Add("Понедельник",1);
dayOfWeeks.Add("Вторник",2);
dayOfWeeks.Add("Среда",3);
dayOfWeeks.Add("Четверг",4);
dayOfWeeks.Add("Пятница",5);
dayOfWeeks.Add("Суббота",6);
dayOfWeeks.Add("Воскресенье",7);
 //Это была проверка работы словаря
//  for (int i = 0; i < dayOfWeeks.Count; i++)
//  {
//       Console.WriteLine("Key " + dayOfWeeks.ElementAt(i).Key + " Value " + dayOfWeeks.ElementAt(i).Value);
//  }
// Проверяем введенное значение на нулл и на то, что оно меньше 8
if (inputLine != null && int.Parse(inputLine)<8 )
{
    int inputNumber = int.Parse(inputLine);
    //Если число больше 5, то выводим текст + день недели
    if (inputNumber > 5) {
        Console.WriteLine(dayOfWeeks.ElementAt(inputNumber-1).Key+" - это выходной");
    }
    //Если число меньше 6, то выводим текст + день недели

    else {
        Console.WriteLine(dayOfWeeks.ElementAt(inputNumber-1).Key+" - это будний день, надо на работу");
    }
}
else
{
    Console.WriteLine("Введите число от 1 до 7");
}