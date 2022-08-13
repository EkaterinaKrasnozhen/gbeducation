// Задача 37: Найдите произведение пар чисел в одномерном массиве.
//Парой считаем первый и последний элемент, второй и предпоследний
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21
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
int[] MultiArrayElem (int[] array)
{
    //if (array.Length % 2 == 0)
    //{
    // int[] newArray = new int[array.Length / 2];
    // for (int i = 0; i < array.Length / 2; i++)
    //  {
    //      newArray[i] = array[i] * array[array.Length - 1 - i];

    //   }
    //  return newArray;
    //  }
    if (array.Length % 2 == 1)
    {
        int[] newArray = new int[array.Length / 2 + 1];
        int[] newArraySecond = new int[array.Length / 2];
        for (int i = 0; i < array.Length / 2; i++)
        {
            newArray[i] = array[i] * array[array.Length - 1 - i];
            newArray[newArray.Length - 1] = array[array.Length / 2];

        }
        
        //return newArray;
        if (array.Length % 2 == 0)
        {
            newArraySecond = array[i] * array[array.Length - 1 - i];
            return newArraySecond;
        }
    }

}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        if (i < num.Length) Console.Write(num[i] + " ");
    }
}
int[] array = CreateArrayRndInt(7, 1, 5);
PrintArray(array);
int[] count = MultiArrayElem(array);
Console.Write("-> ");
PrintArray(count);
