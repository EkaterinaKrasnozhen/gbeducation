/* Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5" */
Console.Write("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число, больше первого ");
int num2 = Convert.ToInt32(Console.ReadLine());
void NaturalNumaber (int number1, int number2) //4,3,2,1 b 0 выход
{
if (number1 == number2) 
{
Console.WriteLine(number1);
return;
}
if (number1 >number2)
{
Console.Write($"{number1}");
NaturalNumaber(number1-1,number2);
}

else
{
Console.Write($"{number1}");
NaturalNumaber(number1+1,number2);
}

}

NaturalNumaber(num1,num2);