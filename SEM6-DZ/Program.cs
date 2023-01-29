/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

/*
int[] createArray()
{
    int size = 5;
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите число " + (i+1));
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
} 
 
void findSum (int[] newArray)
{
    int sum = 0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0)
        {
            sum ++;
        }
    }
    Console.WriteLine ($"Количество положительных чисел = {sum}");
}
 

int[] Array = createArray();
findSum(Array);
Console.WriteLine(String.Join(" ", Array));
*/


/* Задача 43: Напишите программу, которая найдёт точку пересечения
двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */


Console.WriteLine ("Введите b1 ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите k1 ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите b2 ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите k2 ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.WriteLine ("Точка пересечения двух прямых имеет координаты: " + x + " ; " + y);