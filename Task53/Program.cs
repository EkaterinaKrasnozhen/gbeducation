/*Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 5);
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
int [,] matrPr = GetMatrix(3,4);
PrintMatrix(matrPr);
int [,] ChangeRow(int [,] matrix)
{
int j =0;
int i = 0;
int temp =0;
int indexLastRow = matrix.GetLength(0)-1;
int indexLastColumn = matrix.GetLength(1)-1;

    while (j<matrix.GetLength(1))
    {
        temp = matrix [i,j];
        matrix [i,j] = matrix[indexLastRow,j];
        matrix[indexLastRow,j] = temp;
        j++;
    } 
    return matrix;
}  
int [,] result = ChangeRow(matrPr);
Console.WriteLine();

PrintMatrix(result);
