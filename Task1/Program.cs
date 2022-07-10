Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число квадратный корень указанного числа ");
int b = Convert.ToInt32(Console.ReadLine());
int res = b*b;
if(res==a)
    Console.WriteLine($"Да, {b} является квадратным корнем числа {a}");
else Console.WriteLine($"Нет, {b} не является квадратным корнем числа {a}");       

      
