//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
/*
int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(" \t");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(" \t");
        else Console.WriteLine(" ");
    }
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);
*/


// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
/*
int[,] Create2DArrayInt(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArrayInt(rows, columns);

Print2DArrayInt(myArray);
*/
/*
// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(" \t");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(" \t");
        else Console.WriteLine(" ");
    }
}

int[,] TwoDArrayQuard(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            if( i % 2 == 0 &&  j % 2 == 0)
            {
                array[i,j] = array[i,j] * array[i,j];
            }
        }
    }
    return array;
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);

int[,] newArray = TwoDArrayQuard(myArray);

Console.WriteLine();
Print2DArrayInt(newArray);
*/
// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали
//(с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали:1+9+2=12
/*
int[,] Create2DArrayRandomInt(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}
void Print2DArrayInt(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (var j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j]);
            if (j < array.GetLength(1) - 1)
                Console.Write(" \t");
        }
        if (i < array.GetLength(0) - 1)
            Console.WriteLine(" \t");
        else Console.WriteLine(" ");
    }
}

Console.Write("Input a numbers of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numbers of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[,] myArray = Create2DArrayRandomInt(rows, columns, min, max);

Print2DArrayInt(myArray);

int SumDiagonal(int[,] array)
{
int sum = 0;
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(0); j++)
    {
        if(i == j)
        {
            sum = sum + array[i,j];
        }
    }
}
    return sum;
}

int result = SumDiagonal(myArray);
Console.WriteLine($"Summa diagonal is {result}.");
*/