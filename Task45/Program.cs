/* Задача 45: Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */
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
int [] ArrayCopy(int [] arr) 
{
    int [] copy = new int[arr.Length];
    for (int i = 0; i < copy.Length; i++)
    {
        copy[i] = arr[i];
    }
    return copy;
}
void PrintArray(int [] numbers) 
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == 0) Console.Write ("[");
        if (i < numbers.Length-1) Console.Write (numbers[i] + ",");
        else  Console.Write (numbers [i] + "]");
    }
}
int[] numbers = CreateArrayRndInt(6,1,10);
PrintArray(numbers);
int [] copyDone = ArrayCopy(numbers);
PrintArray(copyDone);