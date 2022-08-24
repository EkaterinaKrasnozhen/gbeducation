/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumRecurs(int number)
{
    int sum = number % 10;

    if (number >= 1)
        sum += SumRecurs(number / 10);
    return sum;

}

int res = SumRecurs(num);
Console.Write(res);