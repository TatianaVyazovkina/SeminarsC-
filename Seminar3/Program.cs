/*
//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int FindQuart(double x, double y)
{
    int quart = 0;

    if (x > 0 && y > 0) quart = 1;
    if (x < 0 && y > 0) quart = 2;
    if (x < 0 && y < 0) quart = 3;
    if (x > 0 && y < 0) quart = 4;  
    
    return quart ;   
}
Console.Write("Input x-coordinat:  ");
double x = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y-coordinat:  ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"The point A({x}, {y}) is on the {FindQuart(x,y)} quart");
*/
/*
//Задача 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)

void FindCoordQuart (int quart)
{
    if(quart == 1) 
    {
        Console.Write("Range x > 0 && y > 0");
    }
    if(quart == 2) 
    {
        Console.Write("Range x < 0 && y > 0");
    }
    if(quart == 3) 
    {
        Console.Write("Range x < 0 && y < 0");
    }
    if(quart == 4) 
    {
        Console.Write("Range x > 0 && y < 0");
    }
}

Console.Write("Input quart: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindCoordQuart(quart);
*/
/*
//Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double DistanSecondPoint(double x1, double y1, double x2, double y2)
{
    double b = x2 - x1;
    double c = y2 - y1;
    double b1 = Math.Pow(b, 2);
    double c1 = Math.Pow(c, 2);
    double a1 = b1 + c1;
    double a = Math.Round(Math.Sqrt(a1), 2);
    return a;
}

Console.Write("Input x1-coordinates of the point A: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1-coordinates of the point A: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2-coordinates of the point B: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x3-coordinates of the point B: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ($"Distance between points with coordinates A({x1},{y1}) and B({x2},{y2}) is on the {DistanSecondPoint(x1,y1,x2,y2)}");
*/
/*
//Задача 3.Напишите программу, которая принимает на вход число (N) и выводит квадраты чисел от 1 до N.

void SquarNumber(int n)
{
    int num = 1;
    while(num <= n)
    {
       Console.Write($"{Math.Pow(num,2)} ");
       num++;
    }
}
Console.Write("Input number:  ");
int n = Convert.ToInt32(Console.ReadLine());
SquarNumber(n);
*/