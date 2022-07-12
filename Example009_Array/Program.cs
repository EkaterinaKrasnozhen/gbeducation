int [] array = {9,8,22,6,5,22};
int n = array.Length;
int find = 22;
int index = 0;
while (index<n) 
{
  if (array[index] == find)
   {
    Console.WriteLine(index);
    //break; если нужно найти только первый элемент, совпадающий с find - написать break, 
    //если нет  - покажет все индексы, совпадающие с числом find
   }
   index++;
}