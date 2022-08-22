/*
// Задача 1. Напишите программу, кторая принимает на вход два числа и выдает, какое число большее, а какое меньшее.
int num;
int num1;

// Ввод исходных данных
Console.Write("Введите первое число: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num1 = Convert.ToInt32(Console.ReadLine());

if (num > num1) {
    Console.WriteLine("Максимальное число равно: " + num);
    Console.WriteLine("Минимальное число равно: " + num1);
}
else {
    Console.WriteLine("Максимальное число равно: " + num1);
    Console.WriteLine("Минимальное число равно: " + num);
}

// Задача 2. Напишите программу, кторая принимает на вход три числа и выдает максимальное из этих чисел.
int num;
int num1;
int num2;

// Ввод исходных данных
Console.Write("Введите первое число: ");
num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
num2 = Convert.ToInt32(Console.ReadLine());

// Нахождение максимального числа
int Max = num;

if (num > Max) {
    Max = num;
}
if (num1 > Max) {
    Max = num1;
}
if (num2 > Max) {
    Max = num2;
}
// Вывод ответа на экран
Console.WriteLine("Максимальное число равно: " + Max);

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
int num;

// Ввод исходных данных
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0) {
    Console.WriteLine("четное ");
    }
else {
    Console.WriteLine("не четное ");
    }
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
int num, i;

// Ввод исходных данных
Console.Write("Введите число: ");
num = Convert.ToInt32(Console.ReadLine());  

for (i=1; i<=num; i++)
{
    if (i % 2 == 0) {
        Console.Write(i + " ");
    }
}
