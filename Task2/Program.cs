//Напишите программу, которая будет выдавать
//название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница
Console.WriteLine("Введите число от 1 до 7" );
int day_week = Convert.ToInt32(Console.ReadLine());
if(day_week == 1) {
  Console.WriteLine("понедельник");  
} else if(day_week == 2) {
   Console.WriteLine("вторник"); 
} else if(day_week == 3) {
   Console.WriteLine("среда");
} else if(day_week == 4) {
   Console.WriteLine("четверг");
} else if(day_week == 5) {
   Console.WriteLine("пятница");
} else if(day_week == 6) {
   Console.WriteLine("суббота");
} else if(day_week == 7) {
   Console.WriteLine("воскресенье");
} else {
   Console.WriteLine("число больше или меньше указанного диапазона");
}