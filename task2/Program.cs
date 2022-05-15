// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
string NumberStr = Console.ReadLine();

int number = int.Parse(NumberStr);

if (number>99)
{
    Console.WriteLine("Третья цифра заданного числа: ");
    Console.WriteLine(number.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры в заданном числе нет");
}