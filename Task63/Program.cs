/* Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */
Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
void NaturalNumaber (int number) //4,3,2,1 b 0 выход
{
if (number == 0) return;
NaturalNumaber(number -1); //складываются значения как тарелки дру на друга, стэк
Console.Write($"{number} "); // на вывод берется значение верхнее и идет вниз
}
NaturalNumaber(num);