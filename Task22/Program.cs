﻿// Задача 22: Напишите программу, которая
//принимает на вход число (N) и выдаёт таблицу
//квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
void FindSquared(int num)
{
    int count =1;
    while (count<=num) 
    {
        Console.WriteLine($"| {count} |  {count*count  , 2} |");
        count++;
    }
}
FindSquared(n);
