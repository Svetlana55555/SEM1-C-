/*Console.Write("Введите число: ");

//int a = int.Parse(Console.ReadLine());
int a = Convert.ToInt32 (Console.ReadLine());

//Console.WriteLine("Квадрат " + Convert.ToString(a) + "=" + (a * a));
//Console.WriteLine("Квадрат " + a + "=" + (a * a));
Console.WriteLine($"Квадрат {a} = {a * a}");*/

//Закомментировать одну строку
/*Закомментировать много строк*/

//ДОМАШНЕЕ ЗАДАНИЕ. Задача 2

/*Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
Console.Write("max = ");
Console.WriteLine(max);*/

//ДОМАШНЕЕ ЗАДАНИЕ. Задача 4

/*Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32 (Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32 (Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.Write("max = ");
Console.WriteLine(max);*/

//ДОМАШНЕЕ ЗАДАНИЕ. Задача 6

/*Console.Write("Введите число: ");
int a = Convert.ToInt32 (Console.ReadLine());
if (a%2 == 0)
{
    Console.Write("Число чётное!");
}
else 
{
    Console.Write("Число нечётное!");
}*/

//ДОМАШНЕЕ ЗАДАНИЕ. Задача 8

Console.Write("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
while (i <= N) 
{
	if (i%2 == 0) 
    {
        Console.WriteLine(i);      
    }
i++;
}
