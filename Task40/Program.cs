// Задача 40: 
//1/ Напишите программу, которая принимает на вход три числа 
//2/и проверяет, может ли существовать треугольник с сторонами
//такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника
//меньше суммы двух других сторон.
Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число C: ");
int c = Convert.ToInt32(Console.ReadLine());
bool Triangle(int i, int j, int m) 
{
    if (i<j+m && j<i+m && m<i+j) return true;
    else return false;
}
if (Triangle(a,b,c))
Console.WriteLine($"Треугольник со сторонами А,В,С может существовать" );
else 
Console.WriteLine ($"Треугольник со сторонами А,В,С не может существовать" );
