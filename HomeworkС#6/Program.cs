// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int KolvoBolsheNol(int[] mas)
{
    int Kolvo = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] > 0)
        {
            Kolvo++;
        }
    }
    return Kolvo;
}

Console.WriteLine("Введите количество чисел которые вы хотите ввести: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[num];
int nomer = 1;
for (int n = 0, j = 0; n < num; n++, j++)
{
    Console.WriteLine($"Введите число №{nomer++}: ");
    int thislo = Convert.ToInt32(Console.ReadLine());
    mass[j] = thislo;
}
int rezult = KolvoBolsheNol(mass);
Console.WriteLine($"Сумма чисел больше нуля = {rezult} ");
