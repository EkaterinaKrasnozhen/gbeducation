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
int [] MultiArrayElem(int[] array)
{
    int[] newArray = new int[array.Length/2];
    //int index = 1;
    //int findLength = array.Length / 2;
    //int middle = findLength;
    int half = array.Length%2;
        
        if (half == 0)
        {
            for (int i = 0; i < array.Length/2; i++) 
            {
            newArray [i]= array[i] * array[array.Length - 1-i];
            
            }
            

        }
        return newArray;
        //if (half == 1)
        //{
           // array[i] = array[i] * array[array.Length/2 - index];
           // index++;
            
            //arrayNew[i] = array[findLength+index]*array [array.Length/2+index];
        //}
    
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
int [] array = CreateArrayRndInt(4,1,5);
PrintArray(array);
int [] count = MultiArrayElem(array);
PrintArray(count);