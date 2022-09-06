// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] Array (int size)
{
int[] array = new int[size];    //Создали массив заданной размерности
for (int i =0; i < array.Length; i++) // Заполняем массив случайными цифрами стр 9-11
{
    array [i] = new Random().Next(1, 99);
}
return array;
}
int [] res = Array (5);

void VivodMassiva()
{
    Console.Write("[");                     //Красиво выводим массив строки 13-18
for (int i = 0; i < res.Length - 1; ++i)
{
    Console.Write(res[i] + " ");
}
Console.Write(res[res.Length - 1] + "] ");
}
VivodMassiva();

int SumaElement()
{
int sum = 0;
for (int i = 0; i < res.Length; ++i)
{
    if (res[i] % 2 > 0) sum = sum + res [i];
}
return sum;
}
int Suma = SumaElement();
Console.WriteLine(SumaElement());
