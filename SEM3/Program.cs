/*Задача 17. Напишите программу, которая принимает на вход координаты X и Y, 
причем они не равны 0, и выдает номер четверти плоскости,
в которой находится точка. Четверти справа налево.*/

/* Console.Clear();
Console.WriteLine("Введите координату точки по оси X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки по оси Y ");
int y = Convert.ToInt32(Console.ReadLine());
if(x>0 && y>0) {
    Console.WriteLine("Точка находится в первой плоскости");
} else if (x<0 && y>0) {
    Console.WriteLine("Точка находится во второй плоскости");
} else if(x<0 && y<0) {
    Console.WriteLine("Точка находится в третьей плоскости");
} else if (x>0 && y<0) {
    Console.WriteLine("Точка находится в четвертой плоскости");
} else {
    Console.WriteLine("Четверть определить невозможно");
}
 */

/*
 void PrintCord(int x, int y) {} //метод (процедура)
 if(x>0 && y>0) {
    Console.WriteLine("Точка находится в первой плоскости");
} else if (x<0 && y>0) {
    Console.WriteLine("Точка находится во второй плоскости");
} else if(x<0 && y<0) {
    Console.WriteLine("Точка находится в третьей плоскости");
} else if (x>0 && y<0) {
    Console.WriteLine("Точка находится в четвертой плоскости");
} else {
    Console.WriteLine("Четверть определить невозможно");
}


Console.Clear();
Console.WriteLine("Введите координату точки по оси X ");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату точки по оси Y ");
int coordY = Convert.ToInt32(Console.ReadLine());
PrintCord(coordX,coordY); //вызываем метод
PrintCord(-10,20); //снова вызываем метод
PrintCord(6,-5); //снова вызываем метод
//всё это процедура, поскольку она не возвращает никаких значений
//если добавить return, чтобы был возврат значения, то получилась бы функция, 
//и  возвращаемое значение можно сохранить, записать.

*/


// Задача 18. Напишите программу, которая по заданному номеру четверти 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
Console.Clear();
Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());

switch (quarter) {
    case 1: {
        Console.WriteLine("x > 0, y > 0");
        break;
    }
    case 2: {
        Console.WriteLine("x > 0, y < 0");    
        break;
    }
    case 3: {
        Console.WriteLine("x < 0, y < 0");
        break;
    }
    case 4: {
        Console.WriteLine("x < 0, y > 0");
        break;
    }
    default: {
        Console.WriteLine("Введена неправильная четверть");
        break;
    }
}
*/


//Задача 22. Напишите программу. которая принимает на вход число (N) 
//и выдаёт таблицу квадратов числе от 1 до N.

/* Console.Clear();
Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i = 1; i <= N; i++) {
    Console.Write($"{i*i} ");
} */

//Задача 21. Напишите программу. которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5,09
//A (7,-5); B (1,-1) -> 7,21

Console.Clear();
Console.Write("Введите X1 ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1 ");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2 ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2 ");
int y2 = int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2)); //sqrt - квадратный корень из суммы

Console.WriteLine($"d={d:f5}"); //f5-форматирование до 5 символов