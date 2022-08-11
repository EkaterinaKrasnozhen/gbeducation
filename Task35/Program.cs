// Задача 35: Задайте одномерный массив из 123 случайных чисел.
//Найдите количество элементов массива, значения которых лежат в
//отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
//123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5
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
void PrintArray(int [] numbers) 
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i == 0) Console.Write ("[");
        if (i < numbers.Length-1) Console.Write (numbers[i] + ",");
        else  Console.Write (numbers [i] + "]");
    }
}
int GetNumbers(int[] array)
{
    int count =0;
    for (int i = 0; i < array.Length; i++)
    {
        if (10 < array[i] && array[i] < 99)
        {
            count ++;
        }
        
    }
    return count;
}
int [] array = CreateArrayRndInt(123,-9,1000);
PrintArray(array);
Console.Write("-> " + GetNumbers(array));
