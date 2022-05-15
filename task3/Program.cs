// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет является ли этот день выходным

Console.WriteLine("Введите цифру, обозначающую день недели: ");
string NumberStr = Console.ReadLine();

int number = int.Parse(NumberStr);

if ((number > 0) && (number <= 5))
{
        Console.WriteLine($"День недели {number} является будним днем");
}
else
{
    if ((number > 5) && (number < 8))
{
        Console.WriteLine($"День недели {number} является выходным");
}
        else
{
            Console.WriteLine("Введено некорректное значение");
}
}
