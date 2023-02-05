// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число, мы выведем третью цифру");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
if (a > 99)
{
    while (a > 999)
    {
        a /= 10;
    }
    int result = a % 10;
    Console.WriteLine($"Третья цифра: {result}");
}
else
{
    Console.WriteLine("Вы ввели число без третий цифры");
}





