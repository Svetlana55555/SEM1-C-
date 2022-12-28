//Домашнее задание к Семинару №3

//Задача 19. Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.Write("Введите пятизначное число ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a / 10000) == (a % 10)) {
    if ((a / 1000 % 10) == (a % 100 / 10)) {
    Console.WriteLine("Число палиндром");
}} else {
    Console.WriteLine("Число не палиндром");
}


//Задача 21. Напишите программу, которая принимает на вход 
//координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5,0); B (1,-1,9) -> 11.53

/* Console.Clear();
Console.Write("Введите X1 ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1 ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите Z1 ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2 ");
int y2 = int.Parse(Console.ReadLine());
Console.Write("Введите Z2 ");
int z2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2)); //sqrt - квадратный корень из суммы

Console.WriteLine($"d={d:f5}"); */



//Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт
//таблицу кубов чисел от 1 до N.

/* Console.Clear();
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++) {
    Console.Write($"{i*i*i} ");
} */