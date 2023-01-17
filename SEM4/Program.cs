//Задача 24. Напишите программу, которая принимает на вход число (А) 
//и выдаёт сумму чисел от 1 до А.

Console.Clear();
/* int a = int.Parse(Console.ReadLine());
int all = 0;
for (int x = 0; x <= a; x++)
{
    //all = all + x;
    all += x;
}
Console.Write(all); */

/* int Fx (int a)
{
    int all = 0;
    for (int x = 0; x <= a; x++)
    {
        all += x;
    }
    return(all);
}

Console.WriteLine (Fx(5));
Console.WriteLine (Fx(15)); */
/* 
void GetSumNums (int number)
{
    int sum = 0;
    for (int i = 1; i <= Math.Abs(number); i++)   //Abs-берет по модулю (без учета отрицательных чисел)
    {
        sum += i;
    }
    Console.WriteLine($"Сумма цифр от 1 до {Math.Abs(number)}: {sum}");
}
GetSumNums(-5);
GetSumNums(58);
GetSumNums(25);
GetSumNums(16);

Console.WriteLine("Введите число А");
int n = Convert.ToInt32(Console.ReadLine());
GetSumNums(n);

Console.WriteLine("Введите число А");
GetSumNums(Convert.ToInt32(Console.ReadLine())); */



//Задача 26. Напишите программу, которая принимает на вход число
// и выдаёт количество цифр в числе.

/* void CountNumbs(int numb)
{
    int result = 0;
    if (numb == 0)
    {
        result = 1;
    }
    while(numb >0)
    {
        numb = numb / 10;
        result++;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Введите число");
CountNumbs(Math.Abs(Convert.ToInt32(Console.ReadLine()))); */



//Задача 28. Напишите программу, которая принимает на вход число N
//и выдаёт произведение чисел от 1 до N.

/* int Multiply(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x = x * i;
    }
    return x;
}
Console.Write("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiply(n)); */


/* Console.Clear();
Console.Write("Напишите число (N): ");
int sum = 1;
int a = int.Parse(Console.ReadLine());
for (int i = 1; i <=a; i++)
    {
        sum *= i;
    }
Console.Write(sum); */

//Задача 30. Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

/* int [] mass = new int[8];
for(int i = 0; i < mass.Length; i++)
{
    mass [i] = new Random().Next(2);
    Console.Write(mass [i]);
} */

/* Console.Write("Сколько значений в массиве? ");  //не работает
int[] arr = new int[int.Parse(Console.ReadLine())];

void ArrTrueFalse(int[] array)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
        Console.Write(arr[i]);
    }
} */


/* int[] GenerateArray(int length, int minNum, int maxNum)
{
    int[] arr = new int[length];
        for (int i=0;i<arr.Length;i++)
        {
            arr[i] = new Random().Next(minNum, maxNum + 1);
        }
        return arr;
}

void PrintArray(int[] array)
{
    for (int i=0;i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int arr_len = 8;
PrintArray(GenerateArray(arr_len, 0, 1)); */

//от преподавателя
int[] array = GetBinaryArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");

int[] GetBinaryArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(2);  // от 0 до 2, не включая 2
    }

    return result;
}