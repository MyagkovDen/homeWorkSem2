/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Write("Введите трехзначное число: ");
string userInput = Console.ReadLine() ??"";

int number;
try
{
    number = int.Parse(userInput);
}
catch (System.Exception ex)
{
    Console.WriteLine($"Ошибка ввода! {ex.Message}");
    return;
}
if (99 < number && number < 1000)
{
    int a = number / 10;
    int b = a % 10;
    Console.WriteLine($"{number} -> {b}");
}
else if(-1000 < number && number < -99)
{
    int a = number / 10;
    int b = a % 10;
    Console.WriteLine($"{number} -> {-b}");
}
else
Console.WriteLine("Ошибка ввода! Введенное число не является трехзначным");
