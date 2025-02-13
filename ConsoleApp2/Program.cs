using System;
using System.Runtime.Serialization.Formatters;


int a;
while (true)
{
    Console.Write("Введите количество детей в классе: ");
    if (int.TryParse(Console.ReadLine(), out a) && a > 0)
        break;
    Console.WriteLine("Ошибка! Введите число больше 0");



}

int[] gradeCount = new int[6];

for (int i = 1; i <= a; i++)
{
    Console.Write("Введите имя ученика: ");
    string name = Convert.ToString(Console.ReadLine());

    Console.Write("Введите оценку ученика: ");
    int grade;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out grade) && grade >= 2 && grade <= 5)
            break;

        Console.WriteLine("Ошибка! Введите корректную оценку (от 2 до 5).");
    }
    gradeCount[grade]++;
}

for (int i = 2; i <= 5; i++)
{
    Console.WriteLine($"Оценка {i}: {gradeCount[i]} раз");
}