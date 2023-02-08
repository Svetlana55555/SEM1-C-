/* double Factorial(int n)
{
    if (n == 0) return 1;
    else return n * Factorial(n - 1);
}
for (int i = 1; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
} */

/* Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
 */

 /* Console.WriteLine("Введите значение N");
 int N = int.Parse(Console.ReadLine());
 PrintNumbers(1, N);


 void PrintNumbers(int start, int end)
 {
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start + 1, end);
 } */



/* Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
 */
/* Console.WriteLine("Введите значение M");
 int M = int.Parse(Console.ReadLine());
 Console.WriteLine("Введите значение N");
 int N = int.Parse(Console.ReadLine());
 PrintNumbers(M, N);


 void PrintNumbers(int start, int end)
 {
    Console.Write($"{start} ");
    if (start == end) return;
    PrintNumbers(start + 1, end);
 } 
 */



/* Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.WriteLine("Введите значение N");
int N = int.Parse(Console.ReadLine());

int n = SumNumber (N);
Console.Write(n);
int SumNumber (int number)
{
    int sum = 0;
    if (number == 0)
    {
        return 0;
    }
    sum = number % 10 + SumNumber (number / 10);
    return sum;
}





/* Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
 */



/* функция ack(n, m)
если n = 0
вернуть m + 1
иначе, если m = 0
вернуть ack (n - 1, 1)
еще
вернуть ack(n - 1, ack (n, m - 1)) */