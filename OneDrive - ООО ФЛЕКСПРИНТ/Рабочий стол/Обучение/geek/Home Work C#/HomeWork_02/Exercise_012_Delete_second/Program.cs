//Задача 12: Удалить вторую цифру трёхзначного числа.
Random RandomThreeDigitNumber = new Random(); 
int rtdn = RandomThreeDigitNumber.Next(100, 1000);
Console.WriteLine("Сгенерировано случайное число: " + rtdn);
string str = rtdn.ToString();
Console.WriteLine("Итоговый результат без второй цифры: "  + str[0] + str[2]);