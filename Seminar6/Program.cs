/*
// Задача 39. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] ChangeNewArray(int[] array)
{
    int temp = 0;
    for(int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;    
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] newArray = ChangeNewArray(myArray);
ShowArray(myArray);
*/

/*
//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.Write("Input a number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

if(num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
    Console.Write($"Triangle wiht sides {num1}, {num2}, {num3} exists");
else
    Console.Write($"Triangle wiht sides {num1}, {num2}, {num3} does not exist");
*/
/*
//Задача 42: Напишите программу, которая будет преобразовывать 
//десятичное число в двоичное.
//45 -> 101101, 3 -> 11, 2 -> 10

Console.Write("Input a decimal number: ");
int num = Convert.ToInt32(Console.ReadLine());
string result = string.Empty;
while(num > 0)
{
    result = Convert.ToString(num % 10, 2) + result;
    num /= 10;
}
Console.WriteLine("Binary number is  " + result);
*/
/*
//Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8

int[] SeriosOfFibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for(int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

Console.WriteLine("How many Fibonacci numbers to count? ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myArray = SeriosOfFibonacci(num);
foreach(int k in myArray)
{
Console.Write($"{k} ");
}
*/
/*
//Задача 45: Напишите программу, которая будет создавать 
//копию заданного массива с помощью поэлементного копирования.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[] myArray = CreateRandomArray(size, min, max);

ShowArray(myArray);

int[] copy = new int[myArray.Length];
Array.Copy(myArray, copy, myArray.Length);
Console.WriteLine(String.Join(" ", copy));
*/