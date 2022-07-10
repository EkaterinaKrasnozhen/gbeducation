Console.WriteLine("Укажите трехзначное целое число");
int num = Convert.ToInt32(Console.ReadLine());
int indexLast = num % 10;
Console.WriteLine(indexLast);