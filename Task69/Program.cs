/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */
Console.WriteLine("Введите число A: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int Num1MultNum2(int a, int b) 
{
    int sum = 0;
if (b>=1) return a;
a*a;
Num1MultNum2(a,b-1);


return a;
}
int res = Num1MultNum2(num1,num2);