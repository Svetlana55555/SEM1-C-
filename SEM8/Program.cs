//Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.
/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 10);
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

Console.WriteLine();

int[,] SwapArray(int[,] array)
{
    int n;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        n = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0)-1,i] = n;
    }
    return array;
}
SwapArray(array);
PrintArray(array);
*/


//от Артемий Шмедов
/* int[,] ReversFirtLastRowIntArray2D (int[,] arr)
{
int[] rowFirst = new int[arr.GetLength(0)];
int lastIndexRow = arr.GetLength(0) - 1;
for (int j=0; j < arr.GetLength(1); j++)
{
rowFirst[j] = arr[0,j];
arr[0,j] = arr[lastIndexRow, j];
arr[lastIndexRow, j] = rowFirst[j];
}
return arr;
}  */


//от Борис
/*
int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

void SwapRows(int[,] table, int fromRow, int toRow)
{
    int tmp;
    for (int i=0;i<table.GetLength(1);i++)
    {
        tmp = table[fromRow, i];
        table[fromRow, i] = table[toRow, i];
        table[toRow, i] = tmp;
    }
}

int[,] myArr = GenerateArray(3, 4, 0, 10);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
SwapRows(myArr, 0, myArr.GetLength(0)-1);
Console.WriteLine("После перестановки строк массив выглядит");
PrintArray(myArr);
*/


//////////////////////////////////////////////////////////////////////////////////////////////



//Задача 55: Задайте двумерный массив. Напишите программу, 
//которая заменяет строки на столбцы. В случае, если это невозможно, 
//программа должна вывести сообщение для пользователя.

/*
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());
if (rows == columns)
{
int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
int [,] newarray = ReversRowColArray2D(array);
PrintArray(newarray);
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
            Console.Write(inArray[i, j] + " ");
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

int[,] ReversRowColArray2D(int[,] arr)
{
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            newArr[j, i] = arr[i, j];
        }
    }
    return newArr;
}

*/


//от Константин Мазунин
/* Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

Console.Write("Введите минимальное значение массива: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Введите максимальное значение массива: ");
int max = int.Parse(Console.ReadLine());

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

int[,] array = GetArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();

void PrintArray(int[,] inArray)
{
for (int i = 0; i < inArray.GetLength(0); i++)
{
for (int j = 0; j < inArray.GetLength(1); j++)
{
Console.Write($"{inArray[i,j]} ");
}
Console.Wr */


//от Борис
/*
int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] TurnTable(int[,] table)
{
    int[,] result = new int[table.GetLength(1), table.GetLength(0)];
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            result[j,i] = table[i, j];
        }
    }
    return result;
}

int[,] myArr = GenerateArray(3, 4, 0, 10);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
int[,] secondArr = TurnTable(myArr);
Console.WriteLine("После поворота массива получится");
PrintArray(secondArr);
*/



////////////////////////////////////////////////////////////////////////////////////////////////////////


//Задача 57: Составить частотный словарь элементов двумерного массива. 
//Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

//от Борис
/*
int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] GetDifferentNumbers(int[,] table)
{
    string numbers = String.Empty;
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            if (!numbers.Contains(table[i,j].ToString()))
            {
                if (string.IsNullOrEmpty(numbers)) numbers += $"{table[i,j].ToString()}";
                else numbers += $",{table[i,j].ToString()}";
            }
        }
    }
    Console.WriteLine("Варианты цифр "+numbers);
    string[] numbersArr = numbers.Split(',');
    int[] result = new int[numbersArr.Length];
    int k = 0;
    foreach (string number in numbersArr)
    {
        result[k] = Convert.ToInt32(number);
        k++;
    }
    return result;
}
int[,] TableFreqValues(int[,] table)
{
    int[] uniqueNumbers = GetDifferentNumbers(table);
    int[,] result = new int [uniqueNumbers.Length, 2];
    for (int i=0;i<uniqueNumbers.Length;i++)
    {
        result[i,0] = uniqueNumbers[i];
    }
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            for (int k=0;k<uniqueNumbers.Length;k++)
            {
                if (table[i,j] == result[k,0]) result[k,1]++;
            }
        }
    }
    return result;
}

int[,] myArr = GenerateArray(3, 4, 0, 10);
Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
int[,] freqTable = TableFreqValues(myArr);
Console.WriteLine("Частотный словарь");
PrintArray(freqTable);
*/


//////////////////////////////////////////////////////////////////////////////////////////////////


//Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
/* 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7 */

//от Борис
/*
int[,] GenerateArray(int rows, int columns, int minVal, int maxVal)
{
    int[,] result = new int[rows, columns];
    for (int i=0;i<rows;i++)
    {
        for (int j=0;j<columns;j++)
        {
            result[i,j] = new Random().Next(minVal, maxVal+1);
        }
    }
    return result;
}

void PrintArray(int[,] table)
{
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindFirstCoordinateOfMinPoint(int[,] table)
{
    int[] resultPoint = new int[] {0, 0};
    for (int i=0;i<table.GetLength(0);i++)
    {
        for (int j=0;j<table.GetLength(1);j++)
        {
            if (table[i,j] < table[resultPoint[0], resultPoint[1]])
            {
                resultPoint[0] = i;
                resultPoint[1] = j;
            }
        }
    }
    return resultPoint;
}
int[,] DeleteColumnAndRowWithMinElement(int[,] table)
{
    int[,] result = new int[table.GetLength(0)-1, table.GetLength(1)-1];
    int[] minPointCoord = FindFirstCoordinateOfMinPoint(table);
    Console.WriteLine($"К удалению строки на пересчении координаты ({minPointCoord[0]}, {minPointCoord[1]})");
    // Console.WriteLine($"ARR_SIZE {table.GetLength(0)-1}, {table.GetLength(1)-1}");
    int k=0;
    for (int i=0;i<table.GetLength(0);i++)
    {
        if (i != minPointCoord[0])
        {
            int m=0;
            for (int j=0;j<table.GetLength(1);j++)
            {
                if (j != minPointCoord[1])
                {
                    // Console.WriteLine($"result[{k},{m}] = table[{i},{j}];");
                    result[k,m] = table[i,j];
                    m++;
                }
            }
            k++;
        }

    }
    return result;
}

int[,] myArr = GenerateArray(3, 4, 0, 9);

Console.WriteLine("Сгенерирован массив");
PrintArray(myArr);
int[,] limitedArr = DeleteColumnAndRowWithMinElement(myArr);
Console.WriteLine("Образанный массив");
PrintArray(limitedArr);
*/


/////////////////////////////////////////////////////////////////////////////////////////////////

//Задача 61: Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника



//////////////////////////////////////////////////////////////////////////////////////////////////
//ДЗ
//от Ярослав

//Задача 54
/*
void PrintArray(int[,] inArray) //Отображение массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] GetArray(int m, int n, int minValue, int maxValue) //Создание массива
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] ArrayStringReduction(int[,] array) //Элементы в строке по порядку
{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int coll = 0; coll < array.GetLength(1); coll++)
        {
            for (int k = coll + 1; k < array.GetLength(1); k++)
            {
                if (array[row, k] > array[row, coll])
                {
                    int n = array[row, coll];
                    array[row, coll] = array[row, k];
                    array[row, k] = n;
                }
            }
        }
    }
    return array;
}

int[,] array = GetArray(5, 4, 1, 9);            //Задали массив
PrintArray(array);                              //Отобразили

ArrayStringReduction(array);
PrintArray(array);                              //Отобразили разницу
*/


//Задача 56
/*
void MinSummStringInArray(int[,] array) //Отображение строки с мин суммой
{
    int min = 0;
    int sum = 0;
    int num = 1;
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int coll = 0; coll < array.GetLength(1); coll++)
        {
            sum += array[row, coll];
        }
        Console.Write($"Сумма {row + 1} строки = {sum};\n");
        if (min == 0) min = sum;
        else if (min > sum)
        {
            min = sum;
            num = row + 1;
        }
        sum = 0;
    }
    Console.WriteLine($"Наименьшая сумма в {num}-й строке");
}
//array создалвал с помощью GetArray()
MinSummStringInArray(array);
Console.WriteLine();
*/

//Задача 58
/*
int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB) //Умножение матриц
{
    //Колличество столбцов первой матрицы должно быть равно колличеству строк 2 матрицы
    //Должна умножаться строка на столбец
    int rowsA = matrixA.GetLength(0);
    int colsA = matrixA.GetLength(1);
    int rowsB = matrixB.GetLength(0);
    int colsB = matrixB.GetLength(1);

    if (colsA != rowsB)
    {
        throw new Exception("Ошибка, столбец матрицы А не совпадает со строкой матрицы B");
        //Для того чтобы в консоль выдалась информация о не совпадении
    }

    int[,] result = new int[rowsA, colsB]; //Результирующая матрица

    for (int i = 0; i < rowsA; i++) //строка 1 матрицы
    {
        for (int j = 0; j < colsB; j++) //столбец второй
        {
            for (int k = 0; k < colsA; k++) //строка первой 
            {
                result[i, j] += matrixA[i, k] * matrixB[k, j];
            }
        }
    }

    return result;
}

int[,] matrix1 = GetArray(3, 2, 1, 10);         //Задали 2 матрицы
int[,] matrix2 = GetArray(2, 3, 1, 10);
Console.WriteLine("Матрица А:");
PrintArray(matrix1);                             //Отобразили 2 матрицы
Console.WriteLine("Матрица B:");
PrintArray(matrix2); //Функция вам известна 
Console.WriteLine("Результирующая матрица:");
int[,] matrix = MatrixMultiply(matrix1, matrix2); //Перемножили
PrintArray(matrix);
*/



//Задача 60
/*
int[,,] GetThirdArray(int x, int y, int z, int minValue, int maxValue) //создание трехмерного массива
{
    int[,,] result = new int[x, y, z];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(2); k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

void PrintArrayThird(int[,,] inArray) //Отображение трехмерного массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}

int[,,] arrayThird = GetThirdArray(4, 4, 4, 10, 100); //Трехмерный массив
PrintArrayThird(arrayThird);                          //Отображение трехмерного массива
*/


//Задача 62
/*
int[,] SpiralArray(int rows, int columns, int startNumberSpiral)
{
    int[,] returnSpiral = new int[rows, columns];
    int numberOfSpiral = startNumberSpiral;
    int count = 1; //Счетчик 
    int minRow = 0; // Индекс первой строки
    int maxRow = returnSpiral.GetLength(0) - 1; // Индекс последней строки
    int minColumn = 0;// Индекс первого столба
    int maxColumn = returnSpiral.GetLength(1) - 1;// Индекс последнего столба
    //-1 чтобы не выходить за пределы массива, отсчет же с 0.

    //Цикл, пока счетчик не будет равен длине массива
    while (
        count <= returnSpiral.Length)
    {
        //верхняя строка
        for (int i = minColumn; i <= maxColumn; i++)
        {
            returnSpiral[minRow, i] = numberOfSpiral++;
            count++;
        }
        minRow++;
        // плюсуем потому что когда пойдем в обратном напрлении 
        //minRow по сути станет maxRow то есть числом до которого пойдет отсчет
 
        //Правый столбец
        for (int i = minRow; i <= maxRow; i++)
        {
            returnSpiral[i, maxColumn] = numberOfSpiral++;
            count++;
        }
        maxColumn--;
        //Нижняя строка
        for (int i = maxColumn; i >= minColumn; i--)
        {
            returnSpiral[maxRow, i] = numberOfSpiral++;
            count++;
        }
        maxRow--;
        //Левый столбик
        for (int i = maxRow; i >= minRow; i--)
        {
            returnSpiral[i, minColumn] = numberOfSpiral++;
            count++;
        }
        minColumn++;

    }
    return returnSpiral;

}

int[,] spiral = SpiralArray(8, 7, 10);
PrintArray(spiral); //spiral создалвал с помощью GetArray()
Console.WriteLine();
*/

//от Борис - через рекурсии
/*
void FillArray(int[,] table, int number, int row, int column, int direction = 0)
// direction possible variables
// 0 - go right
// 1 - go down
// 2 - go left
// 3 - go up
{
    if (table[row, column] != 0) return;
    table[row, column] = number;
    if (direction == 0)
    {
        if (column + 1 < table.GetLength(1) && table[row, column+1] == 0) FillArray(table, number+1, row, column+1, direction);
        else FillArray(table, number+1, row+1, column, 1);
    }
    if (direction == 1)
    {
        if (row + 1 < table.GetLength(0) && table[row+1, column] == 0) FillArray(table, number+1, row+1, column, direction);
        else FillArray(table, number+1, row, column-1, 2);
    }
    if (direction == 2)
    {
        if (column - 1 >= 0 && table[row, column-1] == 0) FillArray(table, number+1, row, column-1, direction);
        else FillArray(table, number+1, row-1, column, 3);
    }
    if (direction == 3)
    {
        if (row - 1 >= 0 && table[row-1, column] == 0) FillArray(table, number+1, row-1, column, direction);
        else FillArray(table, number+1, row, column+1, 0);
    }    
}

int rows = 4, columns = 4;
int[,] myArr = new int[rows, columns];
FillArray(myArr, 1, 0, 0);

PrintArray(myArr);
*/