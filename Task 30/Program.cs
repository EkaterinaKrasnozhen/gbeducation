// Задача 30: Напишите программу, которая
//выводит массив из 8 элементов, заполненный
//нулями и единицами в случайном порядке.
///[1,0,1,1,0,1,0,0]

void FillArray(int[] numbers)
{
    Random rnd = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = rnd.Next(0, 2);
    }
}
void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    {
        Console.Write(col[i]);
        if (i != col.Length-1) 
        Console.Write(",");
    }
}
int [] array = new int [8];
FillArray(array);
Console.Write("[");
PrintArray(array);
Console.Write("]");