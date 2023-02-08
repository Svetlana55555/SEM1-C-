/* Задача 64: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* 
Console.WriteLine("Введите значение N (положительное число)");
int N = int.Parse(Console.ReadLine());
PrintNumbers(N, 1);

void PrintNumbers(int start, int end)
{
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start - 1, end);
}
*/

//////////////////////////////////////////////////////////////////////////////////////////////

/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

/*
Console.WriteLine("Введите значение M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = int.Parse(Console.ReadLine());

if (M <= N)
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {SumNumber(M,N)}");
}
else
{
    Console.WriteLine($"Сумма натуральных элементов в промежутке от {N} до {M} = {SumNumber(N,M)}");
}

int SumNumber (int start, int end)
{
    int sum = start;
    if (start == end) return end;
    sum = sum + SumNumber(start + 1, end);
    return sum;
}
*/


/*
Console.WriteLine("Введите значение M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = int.Parse(Console.ReadLine());

Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {SumNumber(M,N)}");

int SumNumber (int start, int end)
{
    int sum = start;
    if (start == end) return end;
        if (M<=N)
        {
            sum = sum + SumNumber(start + 1, end);
        }
        else
        {
            sum = sum + SumNumber(start - 1, end);
        }
    return sum;
}
*/

///////////////////////////////////////////////////////////////////////////////////////////////

/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

/* Console.WriteLine("Введите значение M");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение N");
int N = int.Parse(Console.ReadLine());

Console.WriteLine(Ackermann(M, N));

int Ackermann(int x, int y)
{
    if (x == 0) return y + 1;
    else if (y == 0) return Ackermann(x - 1, 1);
    else return Ackermann(x - 1, Ackermann(x, y - 1));
} */