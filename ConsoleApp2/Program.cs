//Известны оценки каждого из учеников класса. Посчитать количество пятерок, количество четверок,
//количество троек и количество двоек.
using System;

public class StudentGrades
{
    private readonly Dictionary<int, int> gradeCount = new() { { 2, 0 }, { 3, 0 }, { 4, 0 }, { 5, 0 } };

    public void AddGrade(int grade)
    {
        if (gradeCount.ContainsKey(grade))
            gradeCount[grade]++;
    }

    public int GetGradeCount(int grade) => gradeCount.GetValueOrDefault(grade, 0);
}

class Program
{
    static void Main()
    {
        Console.Write("Введите количество учеников: ");
        if (!int.TryParse(Console.ReadLine(), out int studentCount) || studentCount <= 0)
        {
            Console.WriteLine("Ошибка! Введите число больше 0.");
            return;
        }

        StudentGrades studentGrades = new();

        for (int i = 0; i < studentCount; i++)
        {
            Console.Write("Введите оценку ученика: ");
            if (int.TryParse(Console.ReadLine(), out int grade))
                studentGrades.AddGrade(grade);
            else
                Console.WriteLine("Ошибка! Введите корректную оценку (от 2 до 5).");
        }

        foreach (var grade in studentGrades.GetType()
                                           .GetField("gradeCount", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                                           ?.GetValue(studentGrades) as Dictionary<int, int> ?? new())
        {
            Console.WriteLine($"Оценка {grade.Key}: {grade.Value} раз");
        }
    }
}
