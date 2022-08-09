// Задача 28: Напишите программу, которая
//принимает на вход число N и выдаёт
//произведение чисел от 1 до N.
//4 -> 24
//5 -> 120
Console.WriteLine("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int Multi(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count = count * i;
    }
    return count;
}
if (n == 0) Console.Write($"{n}-> 0");
else Console.Write($"{n} ->  {Multi(n)}");
