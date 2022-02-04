//Задача 16: Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Random RandomDayNumber = new Random();
int dayNumber = RandomDayNumber.Next(1, 8);
Console.WriteLine("Сгенерировано число, обозначающее день недели: " + dayNumber);
switch (dayNumber)
{
    case < 6:
        Console.WriteLine("Это рабочий день");
        break;
    default:
        Console.WriteLine("Поздравляю, это выходной день!");
        break;
}