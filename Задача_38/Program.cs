// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] SubstrantialArray (int size)
{
double[] array = new double[size];    //Создали массив заданной размерности
for (int i =0; i < array.Length; i++) // Заполняем массив случайными цифрами 
{
    array [i] = new Random().Next(100, 999) / 100.0;
}
return array;
}
double [] SubArray = SubstrantialArray (5);

void VivodMassiva()           //Красиво выводим массив строки 13-18
{
    Console.Write("[");                     
for (int i = 0; i < SubArray.Length - 1; ++i)
{
    Console.Write(SubArray[i] + " ");
}
Console.Write(SubArray[SubArray.Length - 1] + "] ");
}
VivodMassiva();   

double Difference() //Находим разницу между максимальным и минимальным элементом массива.
{
double min = SubArray[0];
double max = SubArray[0];

for (int i = 0; i < SubArray.Length; ++i)
{
    if (SubArray[i] < min)
    min = SubArray[i];
    if (SubArray[i] > max)
    max = SubArray[i];
}
double dif = max - min;
return dif;
}
double diff = Difference();
Console.Write(Difference());

