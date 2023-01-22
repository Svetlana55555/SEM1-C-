// Задача 39. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

/* int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


int[] Array3 = CreateRandomArray(10,0,500);
ShowArray(Array3);

for(int i = 0; i < Array3.Length/2; i++)
{
    int temp = Array3[i];
    Array3[i] = Array3[Array3.Length - 1 - i]; // -1, чтобы взять последний элемент, -i, чтобы перепрыгнуть на предпоследний
    Array3[Array3.Length - 1 - i] = temp;
}
ShowArray(Array3);
 */

//от Виталия
/* int[] MyArray = CreateRandomArray(15, 1, 1000);


ShowArray(MyArray);

int len =  MyArray.Length;
int j = len - 1;
int temp;

for(int i = 0; i < len / 2; i++, j--){
    temp = MyArray[i];
    MyArray[i] = MyArray[j];
    MyArray[j] = temp;
};

ShowArray(MyArray); */


//Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

//AB < BC + AC && BC < AB + AC && AC < AB + BC

//От Виталия
/* Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int number3 = Convert.ToInt32(Console.ReadLine());
if (number < number2 + number3)
{
    if (number2 < number + number3)
    {
        if (number3 < number2 + number)
        {
            Console.WriteLine("Да, такой треугольник может существовать");
        }
        else
        {
            Console.WriteLine("Нет, такой треугольник не может существовать");
        }
    }
    else
    {
        Console.WriteLine("Нет, такой треугольник не может существовать");
    }
}
else
{
    Console.WriteLine("Нет, такой треугольник не может существовать");
} */





//Задача 42. Напишите программу, которая будет преобразовывать десятичное число 
//в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

/* Console.Clear();

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int N = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateRandomArray(Convert.ToInt32(Math.Log2(N))+1, 0, 1);
int i = 0;
while (N > 0)
{
    Array[Array.Length-i-1] = N % 2;
    N = N/2;
    i++;
}
ShowArray(Array); */

//от Виталия
/* int num = new Random().Next(1, 1000);
num = 136;
int result = from10to2(num);

Console.WriteLine($"num: {num} -> result: {result}");


int from10to2(int num){
    string result = String.Empty;
    while(num > 0){
        result = (num % 2).ToString() + result;
        num /= 2;
        Console.WriteLine($"result: {result}; num: {num}");
    };
    return Convert.ToInt32(result);
}; */


//Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

//от Виталия
/* Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 2)
{
    Console.WriteLine("Введите число больше 2");
}
else
{
int number1 = 0;
int number2 = 1;
int number3 = 0;
Console.WriteLine(number1);
Console.WriteLine(number2);
for(int j = 0; j < number; j++)
{
    number3 = number1 + number2;
    Console.WriteLine(number3);
    number1 = number2;
    number2 = number3; 
}
} */



//Задача 45. Напишите программу, которая будет создавать копию заданного
//массива с помощью поэлементного копирования.

//от преподавателя
/* int[] array = GetArray(10, 0, 10);
WriteLine(String.Join(" ", array));

int[] copyArray=CopyArray(array);
WriteLine(String.Join(" ", copyArray));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}
 */

