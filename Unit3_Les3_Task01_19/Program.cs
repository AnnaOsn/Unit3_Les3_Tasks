// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. (читается слева направо и справа налево одинаково)

// 14212 -> нет

// 12821 -> да

// 23432 -> да
Console.Write("Enter the number: ");
string number = Console.ReadLine();
int Length = number.Length;
if (Length == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
        Console.WriteLine("это палиндром");

    else
        Console.WriteLine("это не палиндром");
}
if (Length!=5)
{Console.WriteLine("это не пятизначное число");
}