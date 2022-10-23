// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5,
// 78 -> третьей цифры нет,
// 32679 -> 6

Console.Write("Введите любое число: ");
int a = int.Parse(Console.ReadLine()!);
int b = a.ToString().Length;
Console.WriteLine(MakeArray(a, b));

int MakeArray(int a, int b)
{
    int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
    return result;
}
















// Console.Write("Введите число от 1 до 7: ");
// int n = int.Parse(Console.ReadLine()!);
// int result = WorkingWeekendDay(n);

// int WorkingWeekendDay(int n)
// {
// if (n >= 1 && n <= 7)
// {
//     if (n == 6 | n == 7) 
//     Console.WriteLine("Сегодня выходной");
//     else 
//     Console.WriteLine("Сегодня рабочий день");
// }
// else Console.WriteLine("Не верное число");
// return n;
// }

