// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число, мы выведем вторую цифру");
int a = Convert.ToInt32(Console.ReadLine());
a = Math.Abs(a);
if(a > 99 && a < 1000)
{
   a = a / 10;
   int result = a % 10;
   Console.WriteLine($"Вторая цифра: {result}");
}
else
{
    Console.WriteLine("Число не трёх значное, введите заново.");
    return;
}

