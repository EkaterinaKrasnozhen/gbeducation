// Задача 26: Напишите программу, которая принимает
//на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5
Console.WriteLine("Введите число от 1 до 9999999999; ");
int num = Convert.ToInt32(Console.ReadLine());
int DigitCount(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count++;
    }
    return count;
}
int result = DigitCount(num);
if (num == 0) Console.WriteLine($"{num}-> 1");
else Console.WriteLine($"{num}-> {result}");