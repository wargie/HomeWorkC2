//Задача 14: Найти третью цифру числа или сообщить, что её нет.
Random RandomThreeDigitNumber = new Random(); 
int rtdn = RandomThreeDigitNumber.Next(1, 1000);
Console.WriteLine("Сгенерировано случайное число: " + rtdn);
switch (rtdn)
{
    case < 100:
        Console.WriteLine("В сгенерированном числе отсутсвует третья цифра!");
        break;
    default:
        {
            string str = rtdn.ToString();
            Console.WriteLine("Третьей цифрой сгенерированного числа является: " + str[2]);
            break;
        }
}