/* Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */
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
int[,] matrPr = GetMatrix(4, 4);
int[,] ChangeRow(int[,] matrix)
{
    
    int i1 = 0;
    int j1 = 0;
    int i2 = 0;
    int j2 = 0;
    int[,] tempMatrix = new int[matrix.GetLength(0),matrix.GetLength(1)];
    while (i1 < matrix.GetLength(0))
    {
        while (j1 < matrix.GetLength(1))
        {
            tempMatrix[i1, j1] = matrix[i2, j2];
            j1++;
            i2++;
        }
        j1 = 0;
        i2 = 0;
        i1++;
        j2++;
    }
    return tempMatrix;
}

PrintMatrix(matrPr);
Console.WriteLine();
int[,] res = ChangeRow(matrPr);
PrintMatrix(res);