////Задача 24: Напишите программу, которая
//принимает на вход число (А) и выдаёт сумму чисел
//от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36
Console.WriteLine("Введите цклое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int Sum(int a)
{
    int index = 1;
    int sum = 0;
    while (index <= a)
    {
        sum = sum + index;
        index++;
    }
    return sum;
}
int result = Sum(num);
if (num < 0 || num == 0) Console.WriteLine("Вы ввели неверное число");
else Console.WriteLine($"{num} => {result}");