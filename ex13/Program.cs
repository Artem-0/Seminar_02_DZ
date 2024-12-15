// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 326791123 -> 6

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100)
{
    System.Console.WriteLine("Третьей цифры нет!");
}
else if (number < 1000)
{
    System.Console.WriteLine($"Третья цифра числа: {number%10}");
}
else
{
    while (number >= 1000)
     {
     number = number / 10;
     }
    System.Console.WriteLine($"Третья цифра числа: {number%10}");
}