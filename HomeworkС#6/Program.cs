// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// int KolvoBolsheNol(int[] mas)
// {
//     int Kolvo = 0;
//     for (int i = 0; i < mas.Length; i++)
//     {
//         if (mas[i] > 0)
//         {
//             Kolvo++;
//         }
//     }
//     return Kolvo;
// }

// Console.WriteLine("Введите количество чисел которые вы хотите ввести: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] mass = new int[num];
// int nomer = 1;
// for (int n = 0, j = 0; n < num; n++, j++)
// {
//     Console.WriteLine($"Введите число №{nomer++}: ");
//     int thislo = Convert.ToInt32(Console.ReadLine());
//     mass[j] = thislo;
// }
// int rezult = KolvoBolsheNol(mass);
// Console.WriteLine($"Сумма чисел больше нуля = {rezult} ");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)


// Решение уравнения
// y = k1 * x + b1, y = k2 * x + b2

// k1* x + b1 = k2 * x + b2
// (k1 - k2) *x = b2 - b1

// x = (b2 - b1) / (k1 - k2);
// y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

Console.WriteLine("Дано уравнение y = k1 * x + b1, y = k2 * x + b2");
Console.WriteLine();
Console.WriteLine("Для его решения нужно ввести следующие данные");

Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;

Console.WriteLine($"Результат x = {x} и y = {y}");



