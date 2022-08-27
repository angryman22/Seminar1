// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

// int number = Convert.ToInt32(Console.ReadLine());

// int square = number * number;// Первый вариант

// int result = Convert.ToInt32(Math.Pow(number,2));// Второй вариант с помощью функции Math

// Console.WriteLine("Квадрат от числа " + number + " = " + result);


// 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

// Console.Write("Введите первое число");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число");
// int b = Convert.ToInt32(Console.ReadLine());
// if (b * b == a)
// {
//     Console.Write("Число " + a + " является квадратом числа " + b);
// }
// else
// {
//     Console.Write("Число " + a + " не является квадратом числа " + b);
// }



// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// i


// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

// int number = Convert.ToInt32(Console.ReadLine());
// int negativNumber = number*(-1);
// while (negativNumber <= number)
// {
//     Console.WriteLine(negativNumber);
//     negativNumber++;
// }

// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
if (a < b) Console.Write("Число " + a + " меньше числа " + b);
else Console.Write("Число " + a + " больше числа " + b);

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int c = Convert.ToInt32(Console.ReadLine());
if (a >= b && a >= c) Console.Write("Число " + a + " является максимальным числом из введенных вами ");
else if (b >= a && b >= c) Console.Write("Число " + b + " является максимальным числом из введенных вами ");
else if (c >= a && c >= b) Console.Write("Число " + c + " является максимальным числом из введенных вами ");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%2 == 0) Console.Write("Число " + number + " является четным");
else Console.Write("Число " + number + " является Нечетным");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= N; i++)
{
    if (i%2 == 0) Console.Write(i + " ");
}