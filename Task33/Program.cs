// Задача 33: Задайте массив. Напишите программу, которая
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    //int[] arr = new int[size]{2,5,6,7} конкретные значения или  int[] arr = {2,5,6,7}
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < numbers.Length - 1) Console.Write(numbers[i] + ",");
        else Console.Write(numbers[i] + "]");
    }
}
Console.WriteLine("Введите число: ");
int findNum = Convert.ToInt32(Console.ReadLine());
void FindNum(int[] array, int search)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == search)
        {
            Console.Write("-> да");
            return;
        }
    }
    Console.WriteLine("-> нет");
}
int[] array = CreateArrayRndInt(4, 1, 3);
PrintArray(array);
FindNum(array, findNum);