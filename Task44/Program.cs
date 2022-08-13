/* Задача 44: Не используя рекурсию, выведите первые N чисел
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] FibNum(int n)

{
    int[] fib = new int[n];
    int i = 2;
    fib[i - 2] = 0;
    fib[i - 1] = 1;
    for (i = 2; i < n; i++)
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
    return fib;
}
int[] result = FibNum(num);
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i < numbers.Length) Console.Write(numbers[i] + " ");
    }
}
PrintArray(result);