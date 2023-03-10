/* Задача 1

Console.WriteLine("Введи число:");
int num = int.Parse(Console.ReadLine()!);
int result = (num/100) * 10 + num%10;
Console.WriteLine($"{num} -> {result}");
//Console.Write($"{num} -> {num1}{num3}");

//Числовое

Console.WriteLine("Введите число: ");
String number = Console.ReadLine()!;
if(number.Length == 3)
{
    Console.WriteLine($"{number} -> {number[0]}{number[2]}");
}
else
{
    Console.WriteLine("Введено неверное число.");
}
*/

// 1. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// 78 -> 8

// 12-> 2

// 85 -> 8

/*
int num = new Random().Next(10, 99);
Console.WriteLine("Сгенерированное число = " + num);
int num1 = num / 10;
int num2 = num % 10;
if(num1 > num2)
{
    Console.WriteLine("Большая цифра = " + num1);
}
else
{
    Console.WriteLine("Большая цифра = " + num2);
}
*/

// 2. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

/*
Console.WriteLine("Введите первое число ");
int arg1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int arg2 = int.Parse(Console.ReadLine()!);
if(arg2 % arg1 == 0)
{
    Console.WriteLine("Число " + arg2 + " кратно числу " + arg1);
}
else
{
    int ostdel = arg2 % arg1;
    Console.WriteLine("Число " + arg2 + " не кратно числу " + arg1 + ". Остаток от деления равен: " + ostdel);
}
*/

// Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

// 14  ->  нет
// 46  ->  нет
// 161 ->  да
/*
//int num = new Random().Next(1, 1000);
int num = int.Parse(Console.ReadLine()!);
if(num % 7 == 0 && num % 23 == 0)
{
    Console.WriteLine("Число " + num + " кратно 7 и 23");
}
else
{
    Console.WriteLine("Число " + num + " не кратно 7 и 23");
}
*/

// Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.

Console.WriteLine("Введите первое число ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число ");
int num2 = int.Parse(Console.ReadLine()!);
if(num1 == (num2 * num2) || num2 == (num1 * num1))
{
    Console.WriteLine("Одно число является квадратом другого");
}
else
{
    Console.WriteLine("Ни первое, ни второе число не является квадратом другого");
}