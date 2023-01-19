//Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.

/* Console.Clear();
Console.WriteLine("Введите число A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{A} в степени {B} = {Degree(A,B)}");

int Degree(int numb, int deg)
{
    if (deg == 0) return 1; 
    
        int result = numb;
        for (int i = 1; i <= Math.Abs(deg); i++)   
        {
            result = result*numb;
        }
        return result;
} */



//Задача 27: Напишите программу, 
//которая принимает на вход число и выдаёт сумму цифр в числе.

/* Console.Clear();
int SumNumbs(int numb)
{
    int sum = 0;
    
    while(Math.Abs(numb) >0)
    {
        sum = sum + (numb % 10);
        numb = numb / 10;
    }
    return sum;
}
Console.WriteLine("Введите число");
int numb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма цифр в числе = {SumNumbs(numb)}"); */


//Задача 29: Напишите программу, которая задаёт массив 
//из 8 элементов и выводит их на экран.

/* int [] mass = new int[8];
for(int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(10);
    Console.Write(mass [i]);
}  */


/* int[] array = GetArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10); 
    }
    return result;
}  */