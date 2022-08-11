// Задача 32: Напишите программу замена элементов
//массива: положительные элементы замените на
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]
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
void ChangeNegPos(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i]*-1;
    }
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
int [] array = CreateArrayRndInt(4,-4,8);
PrintArray(array);
ChangeNegPos(array);
Console.Write("->");
PrintArray(array);
