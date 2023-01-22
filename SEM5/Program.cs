//Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и положительных 
//элементов массива.
//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных 
//чисел равна 29, сумма отрицательных равна -20.

/* 
int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            RandomArray[i] = new Random().Next(start, end + 1);
        }
        return RandomArray;
}
void ShowArray(int[] array)
{
    for (int i =0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] Array1 = CreateRandomArray(12, -9, 9);
ShowArray(Array1);

int positive = 0;
int negative = 0;

for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i] > 0)
    {
        positive += Array1[i];
    }
    else
    {
        negative += Array1[i];
    }
}
Console.WriteLine ($"Сумма положительных чисел = {positive} \n Сумма отрицательных чисел = {negative}");
 */

//От Бориса
/* int[] CountSumsOfElements(int[] arr)
{
int[] result = new int[] {0, 0};
for (int i=0;i<arr.Length;i++)
{
if (arr[i] < 0)
{
result[0] += arr[i];
}
else
{
result[1] += arr[i];
}
}
return result;
} */


//от Виталия
/* int [] mass = new int[12];
int sum = 0;
int sum2 = 0;
for(int i = 0; i < mass.Length; i++)
{
mass [i] = new Random().Next(-9, 9);
Console.Write(" ");
Console.Write(mass [i]);
if(mass[i] < 0)
{
sum2 = sum2 + mass [i];
}
else
{
sum = sum + mass [i];
}
}
Console.WriteLine();
Console.WriteLine($"Сумма отрицательных чисел равна: {sum2}");
Console.WriteLine($"Сумма положительных чисел равна: {sum}"); */



//Задача 32: Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/* int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
return RandomArray;}

//надо добавить void
int[] Array2 = CreateRandomArray(4, -100, 100);
//Console.WriteLine(Array2);
for (int i = 0; i < Array2.Length; i++)
{
    Array2[i] *= -1;
    Console.WriteLine(Array2[i]);
}
 */


//от Виталия
/* int [] mass = new int[12];
for(int i = 0; i < mass.Length; i++)
{
mass [i] = new Random().Next(-9, 9);
Console.Write(" ");
Console.Write(mass [i]);
}
Console.WriteLine();
for(int i = 0; i < mass.Length; i++)
{
mass [i] = mass [i] * -1;
Console.Write(" ");
Console.Write(mass [i]);
} */



//Задача 33: Задайте массив. Напишите программу, которая определяет, 
//присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да






//Задача 35: Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5


//Задача 37: Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21


