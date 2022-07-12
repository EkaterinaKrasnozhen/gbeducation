// Напишите программу, которая выводит случайное
//трёхзначное число и удаляет вторую цифру этого
//числа.
//456 -> 46
////782 -> 72
//918 -> 98
int num = new Random().Next(100, 1000);
int firstDigit = num / 100;
int secondDigit = firstDigit/10;
Console.WriteLine($"{num} {firstDigit}{secondDigit}");

