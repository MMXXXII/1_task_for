using System;

class Program
{
    static void Main()
    {
        int[] grades = new int[4]; // Индексы: 0 - двоек, 1 - троек, 2 - четвёрок, 3 - пятёрок

        Console.Write("Введите количество учеников: ");
        if (!int.TryParse(Console.ReadLine(), out int studentCount) || studentCount <= 0)
        {
            Console.WriteLine("Ошибка! Введите число больше 0.");
            return;
        }

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write("Введите оценку ученика: ");
            if (int.TryParse(Console.ReadLine(), out int grade) && grade >= 2 && grade <= 5)
                grades[grade - 2]++;
            else
                Console.WriteLine("Ошибка! Введите корректную оценку (от 2 до 5).");
        }

        Console.WriteLine($"Двоек: {grades[0]}");
        Console.WriteLine($"Троек: {grades[1]}");
        Console.WriteLine($"Четвёрок: {grades[2]}");
        Console.WriteLine($"Пятёрок: {grades[3]}");
    }
}
