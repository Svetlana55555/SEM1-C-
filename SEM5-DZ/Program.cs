// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество 
//чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/* int[] CreateRandomArray(int size, int min, int max)
{
    int[] RandomArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = new Random().Next(min, max + 1);
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

int[] Array1 = CreateRandomArray(10, 100, 999);
ShowArray(Array1);

int even = 0;

for (int i = 0; i < Array1.Length; i++)
{
    if (Array1[i] % 2 == 0)
    {
        even ++;
    }
}
Console.WriteLine ($"Количество чётных чисел в массиве = {even}"); */



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

/* int[] CreateRandomArray(int size, int min, int max)
{
    int[] RandomArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = new Random().Next(min, max + 1);
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

int[] Array1 = CreateRandomArray(10, -999, 999);
ShowArray(Array1);

int uneven = 0;

for (int i = 1; i < Array1.Length; i++)
{
    if (i % 2 != 0)
    {
        uneven += Array1[i];
    }
}
Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях = {uneven}"); */


// Задача 38: Задайте массив вещественных чисел. Найдите разницу 
//между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] RandomArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            RandomArray[i] = new Random().Next(minValue, maxValue + 1);
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

int[] Array1 = CreateRandomArray(10,0,999);
ShowArray(Array1);

    int min = Array1[0];
    int max = Array1[0];
    for(int i = 0; i < Array1.Length; i++)
    {
        if (min > Array1[i])
        {
            min = Array1[i];
        }
        if (max < Array1[i])
        {
            max = Array1[i];
        }
    }
    int dif = max - min;

Console.WriteLine ($"Разница между максимальным и минимальным элементами массива = {dif}");