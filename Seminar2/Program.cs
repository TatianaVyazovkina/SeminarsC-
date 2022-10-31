/*
int FindBiggestDigit(int num)
{
    int max;
      
    int ed = num % 10;
    int dec = num / 10;

    if(ed > dec)
        max = ed;
    else
        max = dec;
    
    return max;
} 

int number = new Random().Next(10,100);
int biggestDigit = FindBiggestDigit(number);

Console.WriteLine($"The biggest digit of {number} is {biggestDigit}");
*/

/*
//Задача 1 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

int TwoDigitNumber(int num)
{
    int result;
    int ed = num % 10;
    int sot = num / 100;
    result = sot * 10 + ed;
    return result;
} 

int number = new Random().Next(100,1000);
int digitNumber = TwoDigitNumber(number);

Console.WriteLine($"The biggest digit of {number} is {digitNumber}");
*/

/*
//Задача 2 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно a и b.
//a и b - инфо от пользователя(тоже int), true false

bool MultipleyNumber(int num, int a, int b)
{
bool result;

if(num % a == 0 && num % b == 0 )
    result = true;
else
    result = false;

return result;
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Input fist divinder: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second divinder: ");
int b = Convert.ToInt32(Console.ReadLine());
bool multipleyNumber = MultipleyNumber(num, a, b);
Console.WriteLine($"The number of {num} divin {a} and {b} is {multipleyNumber}");
*/
