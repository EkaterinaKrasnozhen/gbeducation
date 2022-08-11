//Задача 31: 
//1/ Задайте массив из 12 элементов, 
//заполненный случайными числами из промежутка [-9, 9]. 
//2. Найдите сумму отрицательных и положительных элементов массива.
// 3. Вывод результата
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
//положительных чисел равна 29, сумма отрицательных равна -20.
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
int[] GetSumPosNegElem(int[] array)
{
    int sumNeg = 0;
    int sumPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sumNeg += array[i];
        }
        else sumPos += array[i];
    }
    return new int[] {sumNeg, sumPos};
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
int [] array = CreateArrayRndInt(12,-9,9);
PrintArray(array);
int [] sumNegPos = GetSumPosNegElem(array);
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел = {sumNegPos[1]}");
Console.WriteLine($"Cумма отрицательных чисел = {sumNegPos[0]}");