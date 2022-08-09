// Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
///[1,0,1,1,0,1,0,0]

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if (i == 0) Console.Write ("[");
        if (i == 7) Console.Write ("]");
        if (i == col.Length-1) Console.Write (",");
    }
}
int [] array = new int [8];
FillArray(array);
PrintArray(array);
