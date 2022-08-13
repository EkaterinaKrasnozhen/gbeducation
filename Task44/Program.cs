/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
void FibNum(int n)

{
    
    int fib0 = 0;
    int fib1 = 1;
    int fibn = 0;
    Console.Write($"{fib0} {fib1} ");
    for (int i = 0; i < n; i++)
    {
        fibn = fib0+fib1;
        Console.Write($" {fibn} ");
        fib0=fib1;
        fib1=fibn;
    }
    
}
FibNum(num);