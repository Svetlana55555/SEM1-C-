//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
SortRows(array);
PrintArray(array);

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}  

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void SortRows(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = j+1; k < array.GetLength(1); k++)
            {
                if (array[i,k]>array[i,j])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i,k] = temp;
                }
            }
        }
    }
}
*/


/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

 
//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/* Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка */
/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива, равное количеству строк: ");
int columns = Convert.ToInt32(Console.ReadLine());

if (rows == columns)
{
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Наименьшая сумма элементов в строке {MinSumRows(array)}");
}
else
{
    Console.WriteLine("Введите равное количество строк и столбцов");
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}  

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int MinSumRows(int[,] array)
{
    int minSum = 0;
    int numRow = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        minSum = minSum + array[0,i];
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            numRow = i;
        }
    }
    return numRow +1;
}
*/

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/* Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

/*
Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array1 = GetArray(rows, columns, 0, 9);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArray(columns, rows, 0, 9);
PrintArray(array2);
Console.WriteLine();
PrintArray(MultiArray(array1, array2));


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i,j] + " ");
        }
        Console.WriteLine();
    }
}  


int[,] MultiArray(int[,] array1, int[,] array2) 
{
    int rows1 = array1.GetLength(0);
    int cols1 = array1.GetLength(1);
    int cols2 = array2.GetLength(1);

    int[,] array3 = new int[rows1, cols2]; //Результирующая матрица

    for (int i = 0; i < rows1; i++) //строка 1 матрицы
    {
        for (int j = 0; j < cols2; j++) //столбец второй
        {
            for (int k = 0; k < cols1; k++) //строка первой 
            {
                array3[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array3;
}
*/

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/* Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
/*
Console.Clear();
Console.Write("Введите первый параметр массива (от 1 до 4) ");
int param1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второй параметр массива (от 1 до 4) ");
int param2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третий параметр массива (от 1 до 5) ");
int param3 = Convert.ToInt32(Console.ReadLine());

int[,,] array = GetThirdArray (param1, param2, param3, 10, 99);
PrintThirdArray(array);


int[,,] GetThirdArray(int x, int y, int z, int minValue, int maxValue) 
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k = 0;
            while(k < result.GetLength(2))
            {
                int temp = new Random().Next(minValue, maxValue +1);
                if (FindElement(result, temp)) continue;
                result[i,j,k] = temp;
                k++;
            }
        }
    }
    return result;
}
     
bool FindElement(int[,,] array, int el)
{
    for (int i=0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if (array[i,j,k] == el) return true;
            }
        }
    }
    return false;
}

void PrintThirdArray(int[,,] inArray) 
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k})   ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
*/


///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/* Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

Console.Clear();
Console.Write("Введите количество строк массива ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns);
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] result = new int[rows, columns];
    int i = 0;
    int j = 0;
    int rowE = m - 1;
    int columnE = n - 1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;

    while (count < rows * columns)
    {
        count++;
        result[i,j] = count;

        if (left && top)  //вправо
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else{
                j++;
                continue;
            }
        }
        if (!left && top)  //вниз
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        if (!left && !top)  //влево
        {
            if (j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else{
                j--;
                continue;
            }
        }
        if(left && !top)  //вверх
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else{
                i--;
                continue;
            }
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (inArray[i,j] < 10)
            {Console.Write("0" + inArray[i,j] + " ");}
            else
            {Console.Write(inArray[i,j] + " ");}
        }
        Console.WriteLine();
    }
}  