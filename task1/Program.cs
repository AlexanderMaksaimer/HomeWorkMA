// Напишите программу, которая принимает на ввод трехзначное число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Введите любое трехзначное число: ");
string NumberStr = Console.ReadLine();
int number = int.Parse(NumberStr);
string strr = number.ToString();
Console.WriteLine($"{number} -> {strr[1]}");


