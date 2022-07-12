// Напишите программу, которая выводит
//случайное число из отрезка [10, 99] и показывает
//наибольшую цифру числа.
//78 -> 8
//12-> 2
//85 -> 8
int num = new Random().Next(10, 100);
//int firstDigit = num/10;
//int secondDigit = num%10;
//if (firstDigit == secondDigit)
//{
 ///   Console.WriteLine("цифры одинаковые");
//}
//else if (firstDigit > secondDigit)
//Console.WriteLine ($" {num} {firstDigit}");
//else Console.WriteLine ($" {num} {secondDigit}");

int Maxdigit(int number)
{
  int firstDigit = num/10;
  int secondDigit = num%10;
  if (firstDigit == secondDigit) return 0;
  if (firstDigit > secondDigit) return firstDigit;
  else Console.WriteLine ($" {num} {secondDigit}");
  return secondDigit;
}

int maxDigit = Maxdigit(num);
if(maxDigit == 0) Console.WriteLine($"цифры одинаковые {num} {maxDigit}");
else Console.WriteLine ($" {num} {maxDigit}");