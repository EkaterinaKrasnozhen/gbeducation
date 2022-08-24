/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int s = 0;
int SumRecurs(int number, int sum)
{
  
    
        if (number == 0) return sum;
    
         sum+= number%10; 
        return SumRecurs(number/10, sum);
        
}

int res = SumRecurs(num, s);
Console.Write(res);