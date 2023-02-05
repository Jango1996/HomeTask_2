// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("введите цифру дня недели и мы проверим является ли он выходным");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber == 6 || DayNumber == 7)
{
    Console.WriteLine("Выходной день");
}
else if (DayNumber > 7 || DayNumber < 1)
{
    Console.WriteLine("Введён не день недели");
}
else
Console.WriteLine("Не выходной день");






