// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да,
// 7 -> да,
// 1 -> нет.


Console.Write("Введите число от 1 до 7: ");
int n = int.Parse(Console.ReadLine()!);
int result = WorkingWeekendDay(n);

int WorkingWeekendDay(int n)
{
if (n >= 1 && n <= 7)
{
    if (n == 6 | n == 7) 
    Console.WriteLine("Да, сегодня выходной");
    else 
    Console.WriteLine("Нет, сегодня рабочий день");
}
else Console.WriteLine("Не верное число");
return n;
}
