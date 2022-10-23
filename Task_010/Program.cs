// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// Например:
// 456 -> 5,
// 782 -> 8,
// 918 -> 1.

Console.Write("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine()!);

int InCenter(int number)
{
    int result = ((number / 10) % 10);
    return result;
}
Console.WriteLine(InCenter(number));