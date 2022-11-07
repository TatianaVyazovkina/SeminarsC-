/*
//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.

int[] CreateArray (int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creaing array: ");
    for(int i = 0; i < size; i++)
    {
        Console.Write($"Input a {i + 1} element of array:  ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("/nComplete!");
    return array;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfNegative(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)
            sum += array[i];          
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOfNegative(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of a negative elements is " + result);
*/
/*
//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

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

int[] ReversArray (int[] array)
{
    for(int i = 0; i < array.Length; i++)
        array[i] = array[i] * -1;

        return array;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int[] result = ReversArray(myArray);

ShowArray(result);
*/

/*
//Задача 3. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

bool Find(int num, int[] array)
{
    for(int i = 0; i < array.Length; i++)
        if(array[i] == num)
            return true;

    return false;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = -100;
int max = 100;

int[] myArray = CreateRandomArray(size, min, max);

Console.Write("Input number to check in my array: ");
int num = Convert.ToInt32(Console.ReadLine());

bool find = Find(num, myArray);
ShowArray(myArray);
Console.Write($"Is there a given number {num} in my array: {find} ");
*/
/*
//Задача 4. Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10n,99m].

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

int CounterNumber(int[] array, int minValue, int maxValue)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] >= minValue && array[i] <= maxValue)
            
            count ++;
    }
    return count;
}

int[] arrayToFind = CreateRandomArray(12, -100, 150);
ShowArray(arrayToFind);
Console.Write("Input minimum value:  ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input maximum value:  ");
int maxValue = Convert.ToInt32(Console.ReadLine());
int count = CounterNumber(arrayToFind, minValue, maxValue);
Console.Write($"Counter numbers in the intervale from {minValue} to {maxValue} is {count}");
*/