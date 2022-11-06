/*
//Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

int GetSum(int a)
{
    int sum = 0;

    for(int current = 1; current <= a; current++)
        sum += current;

    return sum; 
}

Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int s = GetSum(num);
Console.WriteLine($"Sum of elements from 1 to {num} is {s}");
*/
/*
//Задача 2. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int DigitNumber (int num)
{
    int sum = 0;
    while(num > 0)
    {
        num /= 10;
        sum++;
    }

    return sum;
}
Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int digitNumber = DigitNumber(num);
Console.WriteLine($"Digits ot the number {num} is {digitNumber}");
*/
/*
//Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int MultiNumber(int num)
{
    int mult = 1;

    for(int current = 1; current <= num; current++)
        mult *= current;

    return mult;
}
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
int multiNumber = MultiNumber(a);
Console.Write($"The product of number {a} is {multiNumber}");
*/

/*
//Задача 4. Напишите программу, которая выводит массив из m элементов, заполненный нулями и единицами в случайном порядке.

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
int min = 0;
int max = 1;

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
*/