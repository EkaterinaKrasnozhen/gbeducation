/* Задача 59: Задайте двумерный массив из целых чисел.
Напишите программу, которая удалит строку и столбец, на
пересечении которых расположен наименьший элемент
массива. */
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 9);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {


        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < matr.GetLength(1) - 1) Console.Write($"{matr[i, j],3}|");
            else Console.Write($"{matr[i, j],3}]");
        }
        Console.WriteLine();
    }
}
int[,] startMatr = GetMatrix(4, 4);
PrintMatrix(startMatr);
int[] FindMinMatrix(int[,] matrix)
{
    int m = 0;
    int n = 0;
    int minimum = matrix[0, 0];


    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (matrix[i, j] < minimum)
            {
                minimum = matrix[i, j];
                m = i;
                n = j;
            }

        }
    }
    return new int[] { m, n };
}
int[] findMin = (FindMinMatrix(startMatr));

int[,] DelMinimumMatr(int[,] nums, int[] min)
{
    int[,] newNums = new int[nums.GetLength(0) - 1, nums.GetLength(1) - 1];
int m =0;
int n =0;
    
    for (int i = 0; i < newNums.GetLength(0); i++) // alt выделить и удалить или переименовать
    {
        if (m == min[0]) m++;
        for (int j = 0; j < newNums.GetLength(1); j++)
        {
            if (n == min[1]) n++;
            newNums[i, j] = nums[m, n];
            n++;    
        }
        n=0;
        m++;
    }
    return newNums;
}
int[,] res = DelMinimumMatr(startMatr, findMin);
Console.WriteLine();
PrintMatrix(res);