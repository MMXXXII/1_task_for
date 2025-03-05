using System;
using System.Collections.Generic;

class Program
{
    // Метод для ввода и проверки оценки
    static int GetValidGrade(string studentName)
    {
        int grade;
        while (true)
        {
            Console.Write($"Введите оценку для {studentName} (от 2 до 5): ");
            if (int.TryParse(Console.ReadLine(), out grade) && grade >= 2 && grade <= 5)
                return grade;

            Console.WriteLine("Ошибка! Введите корректную оценку (от 2 до 5).");
        }
    }

    // Метод для подсчета оценок
    static Dictionary<int, int> CountGrades(int studentCount)
    {
        // Инициализация словаря с ключами 2, 3, 4, 5 для подсчета оценок
        Dictionary<int, int> gradesCount = new Dictionary<int, int>
        {
            { 2, 0 }, // Двойки
            { 3, 0 }, // Тройки
            { 4, 0 }, // Четверки
            { 5, 0 }  // Пятерки
        };

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write("Введите имя ученика: ");
            string name = Console.ReadLine();

            int grade = GetValidGrade(name);
            gradesCount[grade]++; // Увеличиваем счетчик нужной оценки
        }

        return gradesCount;
    }

    static void Main()
    {
        Console.Write("Введите количество учеников: ");
        if (!int.TryParse(Console.ReadLine(), out int studentCount) || studentCount <= 0)
        {
            Console.WriteLine("Ошибка! Введите число больше 0.");
            return;
        }

        // Получаем подсчитанные оценки
        var grades = CountGrades(studentCount);

        // Вывод результатов
        Console.WriteLine("\nРезультаты:");
        foreach (var grade in grades)
        {
            Console.WriteLine($"Оценка {grade.Key} встречается: {grade.Value} раз");
        }
    }
}
