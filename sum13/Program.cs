/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

long number;

while(true)
{
    Console.Write("Введите число и нажмите enter: ");
    if(long.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("Ошибка ввода!");
}

long num = number;

if (number < 100)
    Console.WriteLine($"{number} -> третьей цифры нет");
else
{
    while (num >= 1000)
    {
        num = num / 10;
    }

    int figure3 = (int)num % 10;
    Console.WriteLine($"{number} -> {figure3}");
}


