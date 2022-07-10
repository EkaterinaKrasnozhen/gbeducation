Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
int count = -(n);
while (count <= n) 
{
    Console.Write($"{count}");
    count++;
}     
 