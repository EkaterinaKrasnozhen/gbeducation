// Задача 18: Напишите программу, которая по
//заданному номеру четверти, показывает диапазон
//возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти ");
int find = Convert.ToInt32(Console.ReadLine());
string Quarter(int numberQuart)
{
    if (numberQuart == 1) return "x > 0 и y > 0";
    if (numberQuart == 2) return "x < 0 и y > 0";
    if (numberQuart == 3) return "x < 0 и y < 0";
    if (numberQuart == 4) return "x > 0 и y < 0";
    return "Введена некорректная четверть";
}
string result = Quarter(find);
Console.WriteLine(result);