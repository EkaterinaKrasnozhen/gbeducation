// Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int a)
{
    int sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int result = Sum(num);
if (num < 0 || num == 0) Console.WriteLine("Вы ввели неверное число");
else System.Console.WriteLine($"Сумма чисел от {1} до {num} = {result}");
