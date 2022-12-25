//Задача 10.
//Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.

/*Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine(number);

Console.Write((number/10)%10);*/


//Задача 13.
//Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.

/*Console.Clear();
Console.Write("Введите положительное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 100) {
    Console.WriteLine("Третьей цифры нет");
} else {
    while (a >= 1000) {
        a /= 10;
    }
    Console.WriteLine("Третья цифра " + (a % 10));
}*/


//Залача 15.
//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

/*Console.Clear();
Console.Write("Введите число от 1 до 7, соответствующее дню недели ");
int a = Convert.ToInt32(Console.ReadLine());
if (a >= 1 && a <= 5) {
    Console.WriteLine("Рабочий день");
} else if (a == 6 || a == 7) {
    Console.WriteLine("Выходной");
} else {
    Console.WriteLine(a + " день недели ещё не придумали");
}*/