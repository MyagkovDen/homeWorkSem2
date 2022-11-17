/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

byte dayNumber;
while(true)
{
    Console.Write("Введите номер дня недели: ");
    if(byte.TryParse(Console.ReadLine(), out dayNumber))
        break;
    Console.WriteLine("Ошибка ввода!");
}

if(0 < dayNumber && dayNumber < 6)
    Console.WriteLine($"{dayNumber} -> нет");
else if(dayNumber == 6 | dayNumber == 7)
    Console.WriteLine($"{dayNumber} -> да");
else
    Console.WriteLine("Ошибка ввода!");
