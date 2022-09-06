// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] Array (int size)
{
int[] array = new int[size];    //Создали массив заданной размерности
for (int i =0; i < array.Length; i++) // Заполняем массив случайными цифрами стр 9-11
  {
    array [i] = new Random().Next(1, 99);
  }
return array;
}
int [] res = Array (9);

void vivodMassiva()                 //Красиво выводим массив строки 13-18
{
    Console.Write("[");                     
for (int i = 0; i < res.Length - 1; ++i)
{
    Console.Write(res[i] + " ");
}
Console.Write(res[res.Length - 1] + "] ");
}
vivodMassiva();

int ChetnyeChisla()
{
int result = 0; 

for (int i =0; i < res.Length; i++) // Проверяем каждый эллемент массива на деление с остатком, если остаток равен нулю то число четное и к result добовляем единицу
{
    if (res[i] % 2 == 0) result++; 
   
}      
return result;
   
}

int Chetn = ChetnyeChisla();
Console.Write(ChetnyeChisla());
