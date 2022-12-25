/*Напишите программу, которя выводит случайное число из отрезка [10, 99],
и показывает наибольшую цифру числа.
Например:
78 -> 8
12 -> 2
85 -> 8
*/

/*Console.Clear();
int number = new Random().Next(10,100);
Console.WriteLine(number);
//95 -> чтобы получить первую цифру 9 = number / 10, вторую цифру 5 = number % 10

if (number/10 > number%10)
{
    Console.WriteLine(number/10);
}
else{
    Console.WriteLine(number%10);
}*/

//рандомное трехзначное число, удалить среднее число
/*Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine(number);

int a = (number/100);
int x = (number%100);
int b = (x/10);
int c = (x%10);

Console.Write(a);
Console.WriteLine(c);*/

/*Console.Write((number / 100));
Console.WriteLine((number % 10));*/



//программа принимает на вход 2 чиса и выводит, является ли второе число кратным первому.
//Если число 2 не кратно первому, то программа выводит остаток от деления.

/*Console.Clear();
int a = new Random().Next(1,999);
int b = new Random().Next(1,999);

Console.WriteLine(a);
Console.WriteLine(b);

if ((a % b) == 0) {
    Console.WriteLine("Число кратное");
} else {
    Console.WriteLine("Не кратное, остаток " + (a % b));
}*/



//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23

/*Console.Clear();
int a = new Random().Next(1,999);

Console.WriteLine(a);
if (((a%7) == 0) && ((a%23) == 0)) {
    Console.WriteLine("Делится на 7 и 23");
} else {
    Console.WriteLine("Не делится на 7 и 23 одновременно");
}*/


//Напишите программу, которая на вход принимает 2 числа и проверяет, 
//является ли одно число квадратом другого.


Console.Clear();
int a = 10;
int b = 1000;

Console.WriteLine(a);
Console.WriteLine(b);

if ((b*b) == a) {
    Console.WriteLine("Первое число является квадратом второго");
} else if ((a*a) == b){
    Console.WriteLine("Второе число является квадратом первого");
} else {
    Console.WriteLine("Ни одно число не является квадратом другого");
}