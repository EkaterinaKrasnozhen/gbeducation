// Задача 42: Напишите программу, которая будет преобразовывать
//десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10
Console.WriteLine("Введите десятичное число: ");
int num_10 = Convert.ToInt32(Console.ReadLine());

void ToBin(int n) 
{
    if (n == 0) return;
    ToBin(n/2);
    Console.Write(n%2);
}
ToBin(num_10);
