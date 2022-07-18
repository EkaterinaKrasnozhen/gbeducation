// Задача 20: Напишите программу, которая
//принимает на вход координаты двух точек и
//находит расстояние между ними в 2D
//пространстве.
//A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21
//AB={2-x1;y2-y1}  AB=V2корень(x2-x1)*2+(y2-y1)*2
Console.WriteLine("Введите координаты точки A");
Console.Write("по оси X");
int ax1 = Convert.ToInt32(Console.ReadLine());
Console.Write("по оси Y");
int ay1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты точки B");
Console.Write("по оси X");
int bx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("по оси Y");
int by2 = Convert.ToInt32(Console.ReadLine());
double S_a_b(int x1, int y1, int x2, int y2) 
{
    int a = ((x2-x1)*(x2-x1));
    int b = ((y2-y1)*(y2-y1));
    double s = Math.Sqrt(a + b);
    return s;
}
double result = S_a_b(ax1,ay1,bx2,by2);
Console.WriteLine (Math.Round(result,2, MidpointRounding.ToZero));