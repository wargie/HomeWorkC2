//Задача 10: Показать вторую цифру трёхзначного числа.
Random RandomThreeDigitNumber = new Random(); 
int rtdn = RandomThreeDigitNumber.Next(100, 1000); 
Console.WriteLine("Выбрано число: " + rtdn); 
string str = rtdn.ToString();
Console.WriteLine("Второй цифрой является: "  + str[1]);