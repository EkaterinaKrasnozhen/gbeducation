/* Задача 46: Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1 */
//[строки, столбцы]
int [,] GetMatrix(int m, int n) 
{
 int[,] matrix = new int[m,n];
 Random rnd = new Random();
 for (int i = 0; i < matrix.GetLength(0); i++)
 {
    for (int j = 0; j < matrix.GetLengthlength(1); j++)
    {
        matrix[i,j] = rnd.Next(1, 100);
    }
 }
 return matrix;
}
void PrintMatrix(int [,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        
    
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if (j == 0) Console.Write ("[");
        if (i < matr.GetLength(1)) Console.Write (numbers[i] + ",");
        else  Console.Write (matr [i,j] + "]");
    }
    }
}
int [,] matrixResult  = GetMatrix (3,4);
PrintMatrix(matrixResult);