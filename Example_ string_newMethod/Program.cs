

using System.Linq;
string text = "(1,2) (2,3) (4,5) (6,7)"
             .Replace("(", "")
             .Replace(")", "");
Console.WriteLine(text);            
var data = text.Split(" ") // есть сепаратор, указыввем, что им будет пробел
               .Select(item => item.Split(',')) // взять неск элементов, символ раделитель ","
               .Select(e=>(x: int.Parse(e[0]), y: int.Parse(e[1]))) //делаем выборку элемента, 
                                                                   //указываем 1 позицию х, 2 у; 
                                                                   //сразу переводим в число
               .Where(e=>(e.x % 2==0)) // возьмем точки с четными значениями по х 
                                    //(делаем проверку условия) (2,3) (4,5) (6,7) из нашей строки
               .Select(point=>(point.x*10, point.y)) //а можно тут указать действия
               .ToArray(); // превратить в массив

for (int i = 0; i < data.Length; i++)
{ 
       Console.WriteLine(data[i]); // можно тут делать действия (data[i].x*10)
        
       Console.WriteLine();      
}

