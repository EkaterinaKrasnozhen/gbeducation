/* Задача 57: Составить частотный словарь элементов
двумерного массива. Частотный словарь содержит
информацию о том, сколько раз встречается элемент
входных данных. */
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


int[] MatrixToArray(int[,] matr)
{
    int[] array = new int[matr.Length];
    int b = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            array[b] = matr[i, j];
            b++;
        }
    }
    Array.Sort(array);
    return array;
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
int[,] arrayMatrix = GetMatrix(3, 4);
PrintMatrix(arrayMatrix);
int[] arrayNew = MatrixToArray(arrayMatrix);
PrintArray(arrayNew);
void CountNumInArray(int[] nums)
{
    int count = 0;
    int number = nums[0];




    for (int i = 0; i < nums.Length; i++)
    {

        if (nums[i] == number)
        {
            
            count++;

        }
        else
        {
            Console.Write($" число {number} встречатся  {count} раз/раза;");
            number = nums[i];
            count = 1;
        }
        if (i == nums.Length - 1)
            Console.WriteLine($" число {number} встречатся  {count} раз/раза;");
    }




}
CountNumInArray(arrayNew);