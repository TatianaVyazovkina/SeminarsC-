/*

// Задача 1. Является ли первое число квадратом второго числа?

Console.Write("Input a first numbers: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second numbers: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quar2 = n2 * n2;

if (quar2 == n1)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}
*/

/*
// Задача 2. Напишите программу, которая на входе принимает одно число (N), на выходе пишет все числа от-N до N.

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current;

if(number > 0)
{
    current = -number;
}
else
{
    current = number;
    number *= -1;
    }

while (current <= number)
{
    Console.Write(current + " ");
    current++;
}

*/


// Задача3. Напишите программу, которая на входе принимает трехзначное число, а на выходе показывает последнюю цифру этого числа.

Console.Write("Input three-digit number: ");
int n = Convert.ToInt32(Console.ReadLine());

if(n >= 100 && n < 1000)
{
    int lastDigit = n % 10;
    Console.WriteLine($"Last digit in {n} is {lastDigit}");
}
else
{
    Console.WriteLine("Uncorrent unput!");
}